using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers;
using System.Collections.Generic;
using System.Linq;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal.Core
{
    internal class CardinalNumberProvider : ICardinalNumberProvider
    {
        protected readonly INumberSeparator _numberSeparator;
        protected readonly ISimpleNumbers _basicNumbers;
        protected readonly ISimpleNumbers _from_2_to_4_thousands;
        protected readonly ISimpleNumbers _up_to_4_thousands;
        protected readonly ISimpleNumbers _1_on_end;
        protected readonly ISimpleNumbers _count_of_thousands;
        protected readonly INumberInWordsConfiguration _configuration;

        public CardinalNumberProvider(INumberSeparator numberSeparator, ISimpleNumbers basicNumbers, ISimpleNumbers from_2_to_4_thousands,
            ISimpleNumbers up_to_4_thousands, ISimpleNumbers a_1_on_end, ISimpleNumbers count_of_thousands, INumberInWordsConfiguration configuration)
        {
            _numberSeparator = numberSeparator;
            _basicNumbers = basicNumbers;
            _from_2_to_4_thousands = from_2_to_4_thousands;
            _up_to_4_thousands = up_to_4_thousands;
            _1_on_end = a_1_on_end;
            _count_of_thousands = count_of_thousands;
            _configuration = configuration;
        }

        public string Provide(long number)
        {
            if (number < 0)
                return ProvideWithMinus(number);

            if (number == 0)
                return GetZero();

            if (number == 1)
                return _basicNumbers.Number_1;

            var separatedNumber = _numberSeparator.Separate(number);

            var elements = new List<string>();

            elements.AddRange(GetAllThousands(separatedNumber));
            elements.AddRange(GetHundreds(separatedNumber));

            var last2digs = GetLast2digs(separatedNumber.Last2digs, _basicNumbers);
            if (last2digs != "")
                elements.Add(last2digs);

            return string.Join(" ", elements);
        }

        protected virtual string ProvideWithMinus(long number)
        {
            return string.Format("{0} {1}", "minus", Provide(-number));
        }

        protected virtual string GetZero()
        {
            return _basicNumbers.Number_0;
        }

        protected virtual IEnumerable<string> GetAllThousands(NumberElements separatedNumber)
        {
            bool firstThousand = true;

            for (var i = separatedNumber.Thousands.Length - 1; i >= 0; i--)
            {
                var (powerOf1000, count) = separatedNumber.Thousands[i];

                var thousand = SolveThousands(powerOf1000, count);

                if (thousand != "")
                {
                    if(_configuration.OneBeforeThousand && count == 1 && firstThousand)
                    {
                        thousand = $"{_count_of_thousands.Number_1} {thousand}";
                    }

                    firstThousand = false;

                    yield return thousand;
                }
            }
        }

        protected virtual IEnumerable<string> GetHundreds(NumberElements separatedNumber)
        {
            if (separatedNumber.Hundreds == 0)
                yield break;

            var hundreds = _basicNumbers.Solve(separatedNumber.Hundreds * 100);
            if (hundreds != "")
            {
                yield return hundreds;
            }
        }

        protected virtual string SolveThousands(int powerOf1000, int count)
        {
            if (count <= 0)
                return "";

            // 1000, 1000000...
            if (count == 1)
                return _basicNumbers.SolveBigNumber(powerOf1000);

            var lastDig = count % 10;
            var last2digs = count % 100;

            // 2000, 3000, 4000, 22000, 23000, 24000, 32000, 33000...
            if (lastDig >= 2 && lastDig <= 4 && (last2digs > 20 || last2digs < 10))
                return string.Format("{0} {1}",
                    GetLast3digs(count, _count_of_thousands),
                    _from_2_to_4_thousands.SolveBigNumber(powerOf1000));

            // 5000, 6000, 7000...
            return string.Format("{0} {1}",
                GetLast3digs(count, _count_of_thousands),
                _up_to_4_thousands.SolveBigNumber(powerOf1000));
        }

        protected virtual string GetLast3digs(int number, ISimpleNumbers simpleNumbers)
        {
            var last2digs = number % 100;
            var hundreds = number % 1000 - last2digs;

            var hundredsSolved = hundreds > 0 ? simpleNumbers.Solve(hundreds) : "";
            var last2digsSolved = GetLast2digs(last2digs, simpleNumbers);

            if (last2digs == 1)
                last2digsSolved = _1_on_end.Number_1;

            var elements = new List<string>();

            if (hundredsSolved != "")
                elements.Add(hundredsSolved);

            if (last2digsSolved.Any())
                elements.Add(last2digsSolved);

            return string.Join(" ", elements);
        }

        protected virtual string GetLast2digs(long number, ISimpleNumbers simpleNumbers)
        {
            if (number == 0)
                return "";

            if (number == 1)
                return _1_on_end.Number_1;

            if (number < 20)
                return simpleNumbers.Solve((int)number);

            var lastDigit = number % 10;
            var tens = number % 100 - lastDigit;

            // 00
            if (lastDigit == 0 && tens == 0)
                return "";

            // 10, 20, 30...
            if (lastDigit == 0)
                return simpleNumbers.Solve((int)tens);

            // 31
            if (lastDigit == 1)
                return string.Format("{0} {1}",
                    simpleNumbers.Solve((int)tens),
                    _1_on_end.Number_1);

            // 25, 46, ...
            return string.Format("{0} {1}",
                simpleNumbers.Solve((int)tens),
                simpleNumbers.Solve((int)lastDigit));
        }
    }
}
