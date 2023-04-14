using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers;
using System.Collections.Generic;
using System.Linq;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal.Core
{
    internal class OrdinalNumberProvider : IOrdinalNumberProvider
    {
        protected readonly INumberSeparator _numberSeparator;
        protected readonly ISimpleNumbers _basicOrdinalNumbers;
        protected readonly ISimpleNumbers _basicCardinalNumbers;
        protected readonly IBigNumbersPrefixes _bigNumbersPrefixes;
        protected readonly ISimpleNumbers _from_2_to_4_thousands;
        protected readonly ISimpleNumbers _up_to_4_thousands;
        protected readonly ISimpleNumbers _hundreds;
        protected readonly INumberInWordsConfiguration _configuration;

        public OrdinalNumberProvider(INumberSeparator numberSeparator, ISimpleNumbers basicOrdinalNumbers,
            ISimpleNumbers basicCardinalNumbers,
            ISimpleNumbers from_2_to_4_thousands,
            ISimpleNumbers up_to_4_thousands,
            IBigNumbersPrefixes bigNumbersPrefixes,
            ISimpleNumbers hundreds,
            INumberInWordsConfiguration configuration)
        {
            _numberSeparator = numberSeparator;
            _basicOrdinalNumbers = basicOrdinalNumbers;
            _basicCardinalNumbers = basicCardinalNumbers;
            _from_2_to_4_thousands = from_2_to_4_thousands;
            _up_to_4_thousands = up_to_4_thousands;
            _bigNumbersPrefixes = bigNumbersPrefixes;
            _hundreds = hundreds;
            _configuration = configuration;
        }

        public string Provide(long number)
        {
            if (number < 0)
                return SolveMinus(number);

            var basicSolved = _basicOrdinalNumbers.Solve(number);

            if (basicSolved != "")
                return basicSolved;

            var separatedNumber = _numberSeparator.Separate(number);

            var elements = new List<string>();

            elements.AddRange(SolveAllThousands(separatedNumber));

            var last3Digs = separatedNumber.Hundreds * 100 + separatedNumber.Last2digs;
            var last3DigsTry = _basicOrdinalNumbers.Solve(last3Digs);
            if (last3DigsTry != "" && last3Digs != 0)
            {
                elements.Add(last3DigsTry);
            }
            else
            {
                elements.AddRange(SolveHundreds(separatedNumber));

                var last2digs = SolveLast2digs(separatedNumber.Last2digs);
                if (last2digs != "")
                    elements.Add(last2digs);
            }

            return string.Join(" ", elements);
        }

        protected virtual string SolveMinus(long number)
        {
            return string.Format("{0} {1}", "minus", Provide(-number));
        }

        protected virtual string GetZero()
        {
            return _basicOrdinalNumbers.Number_0;
        }

        protected virtual string SolveLast2digs(long number)
        {
            if (number == 0)
                return "";

            if (number < 20)
                return _basicOrdinalNumbers.Solve((int)number);

            var lastDigit = number % 10;
            var tens = number % 100 - lastDigit;

            // 00
            if (lastDigit == 0 && tens == 0)
                return "";

            // 10, 20, 30...
            if (lastDigit == 0)
                return _basicOrdinalNumbers.Solve((int)tens);

            // 25, 46, ...
            return string.Format("{0} {1}",
                _basicOrdinalNumbers.Solve((int)tens),
                _basicOrdinalNumbers.Solve((int)lastDigit));
        }



        protected virtual IEnumerable<string> SolveAllThousands(NumberElements separatedNumber)
        {
            var elements = new List<string>();

            for (var i = separatedNumber.Thousands.Length - 1; i >= 0; i--)
            {
                var (powerOf1000, count) = separatedNumber.Thousands[i];

                var sumRestThousands = separatedNumber.Thousands
                    .Reverse()
                    .Skip(separatedNumber.Thousands.Length - i)
                    .Sum(x => x.Count);

                if (sumRestThousands == 0 && count > 0
                    && separatedNumber.Hundreds == 0 && separatedNumber.Last2digs == 0)
                {
                    var solvedThousandWithRestZeros = SolveThousandsWithRestZeros(count, i + 1);
                    elements.Add(solvedThousandWithRestZeros);
                    break;
                }

                var solvedThousand = SolveThousands(powerOf1000, count);

                if (solvedThousand != "")
                {
                    elements.Add(solvedThousand);
                }
            }

            return elements;
        }

        protected virtual string SolveThousandsWithRestZeros(int count, int restPows)
        {
            var elements = new List<string>();

            var ones = count % 10;
            var tens = count % 100 - ones;
            var hundreds = count % 1000 - tens - ones;

            if (hundreds != 0)
                elements.Add(_bigNumbersPrefixes.Solve(hundreds));

            if (tens != 0 && ones == 0)
                elements.Add(_bigNumbersPrefixes.Solve(tens));

            if (ones != 0 && tens == 0 && count != 1)
                elements.Add(_bigNumbersPrefixes.Solve(ones));

            if (ones != 0 && tens != 0)
                elements.Add(_bigNumbersPrefixes.Solve(tens + ones));

            elements.Add(_basicOrdinalNumbers.SolveBigNumber(restPows));

            return string.Join("", elements);
        }

        protected virtual IEnumerable<string> SolveHundreds(NumberElements separatedNumber)
        {
            if (separatedNumber.Hundreds == 0)
                yield break;

            var solvedHundreds = _hundreds.Solve(separatedNumber.Hundreds * 100);
            if (solvedHundreds != "")
            {
                yield return solvedHundreds;
            }
        }

        protected virtual string SolveThousands(int powerOf1000, int count)
        {
            if (count <= 0)
                return "";

            // 1000, 1000000...
            if (count == 1)
                return _basicCardinalNumbers.SolveBigNumber(powerOf1000);

            var lastDig = count % 10;
            var last2digs = count % 100;

            // 2000, 3000, 4000, 22000, 23000, 24000, 32000, 33000...
            if (lastDig >= 2 && lastDig <= 4 && (last2digs > 20 || last2digs < 10))
                return string.Format("{0} {1}",
                    SolveLast3digsInThounsands(count),
                    _from_2_to_4_thousands.SolveBigNumber(powerOf1000));

            // 2001, 2012, 2234...
            return string.Format("{0} {1}",
                SolveLast3digsInThounsands(count),
                _up_to_4_thousands.SolveBigNumber(powerOf1000));
        }

        protected virtual string SolveBigNumbersWithPrefix(string bigNumberPrefix, int powerOf1000)
        {
            var thousandsText = _basicOrdinalNumbers.SolveBigNumber(powerOf1000);

            return string.Format("{0}{1}", bigNumberPrefix, thousandsText);
        }

        protected virtual string SolveLast3digsInThounsands(int number)
        {
            var last2digs = number % 100;
            var hundreds = number % 1000 - last2digs;

            var hundredsSolved = hundreds > 0 ? _basicCardinalNumbers.Solve(hundreds) : "";
            var last2digsSolved = SolveLast2digsInThousands(last2digs);

            if (last2digs == 1)
                last2digsSolved = _basicCardinalNumbers.Number_1;

            var elements = new List<string>();

            if (hundredsSolved != "")
                elements.Add(hundredsSolved);

            if (last2digsSolved.Any())
                elements.Add(last2digsSolved);

            return string.Join(" ", elements);
        }

        protected virtual string SolveLast2digsInThousands(long number)
        {
            if (number == 0)
                return "";

            if (number == 1)
                return _basicCardinalNumbers.Number_1;

            if (number < 20)
                return _basicCardinalNumbers.Solve((int)number);

            var lastDigit = number % 10;
            var tens = number % 100 - lastDigit;

            // 00
            if (lastDigit == 0 && tens == 0)
                return "";

            // 10, 20, 30...
            if (lastDigit == 0)
                return _basicCardinalNumbers.Solve((int)tens);

            // 25, 46, ...
            return string.Format("{0} {1}",
                _basicCardinalNumbers.Solve((int)tens),
                _basicCardinalNumbers.Solve((int)lastDigit));
        }
    }
}
