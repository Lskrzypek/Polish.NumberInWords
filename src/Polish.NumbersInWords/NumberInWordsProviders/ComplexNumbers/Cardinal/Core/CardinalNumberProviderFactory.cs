using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal.Core
{
    internal class CardinalNumberProviderFactory : ICardinalNumberProviderFactory
    {
        protected readonly INumberSeparator _numberSeparator;
        private readonly INumberInWordsConfiguration _configuration;

        public CardinalNumberProviderFactory(INumberSeparator numberSeparator, INumberInWordsConfiguration configuration)
        {
            _numberSeparator = numberSeparator ?? throw new System.ArgumentNullException(nameof(numberSeparator));
            _configuration = configuration ?? throw new System.ArgumentNullException(nameof(configuration));
        }

        public ICardinalNumberProvider Create(
            ISimpleNumbers basicNumbers,
            ISimpleNumbers from_2_to_4_thousands,
            ISimpleNumbers up_to_4_thousands,
            ISimpleNumbers a_1_on_end,
            ISimpleNumbers count_of_thousands)
        {
            return new CardinalNumberProvider(_numberSeparator,
                basicNumbers,
                from_2_to_4_thousands,
                up_to_4_thousands,
                a_1_on_end,
                count_of_thousands,
                _configuration);
        }
    }
}
