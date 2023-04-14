using System;

namespace Polish.NumbersInWords
{
    /// <summary>
    /// Builder to provide numbers in words. Use fluent methods to setup number declension.
    /// </summary>
    public class NumberElementsBuilder
    {
        private readonly INumberElementsProvider _numberElementsProvider;
        private long _number;
        private NumberProperties _numberProperties;
        private INumberInWordsConfiguration _numberInWordsConfiguration = new NumberInWordsConfiguration();

        private INumberElements _numberElements = null;

        /// <summary>
        /// Number elements with the number in words and methods to manipulate it.
        /// </summary>
        public INumberElements NumberElements
        {
            get
            {
                if (_numberElements is null)
                    _numberElements = _numberElementsProvider.Provide(_number, _numberProperties, _numberInWordsConfiguration);

                return _numberElements;
            }
        }

        public NumberElementsBuilder(long number, INumberElementsProvider numberElementsProvider)
        {
            _number = number;
            _numberProperties = NumberProperties.CreateDefault();
            _numberElementsProvider = numberElementsProvider ?? throw new System.ArgumentNullException(nameof(numberElementsProvider));
        }

        /// <summary>
        /// Returns a text created by the defined function. You can use it to create a phrase with specific declension.
        /// </summary>
        public string Write(Func<INumberElements, string> writeFunc)
        {
            return writeFunc(NumberElements);
        }

        /// <summary>
        /// Sets a case of the number. For example: Nominative (Mianownik), Genitive (Dopełniacz) etc.
        /// </summary>
        public NumberElementsBuilder Case(Case @case)
        {
            _numberProperties.Case = @case;
            return this;
        }

        /// <summary>
        /// Sets a gender of the number. For example: Masculine (rodzaj męski), Feminine (rodzaj żeński) etc.
        /// </summary>
        public NumberElementsBuilder Gender(Gender gender)
        {
            _numberProperties.Gender = gender;
            return this;
        }

        /// <summary>
        /// Sets the number as ordinal. For example: first, second... (pierwszy, drugi...)
        /// </summary>
        public NumberElementsBuilder Ordinal()
        {
            _numberProperties.CardinalOrdinal = CardinalOrdinal.Ordinal;
            return this;
        }

        /// <summary>
        /// Sets the number as cardinal. For example: one, two... (jeden, dwa...)
        /// </summary>
        public NumberElementsBuilder Cardinal()
        {
            _numberProperties.CardinalOrdinal = CardinalOrdinal.Cardinal;
            return this;
        }

        /// <summary>
        /// Sets the number to have "one" before big numbers. For example 1008 will be convert to "jeden tysiąc osiem", not just "tysiąc osiem".
        /// </summary>
        public NumberElementsBuilder WithOneBeforeThousand()
        {
            _numberInWordsConfiguration.OneBeforeThousand = true;
            return this;
        }

        public override string ToString()
        {
            return NumberElements.Words;
        }

        public static implicit operator string(NumberElementsBuilder builder) => builder.ToString();
    }
}
