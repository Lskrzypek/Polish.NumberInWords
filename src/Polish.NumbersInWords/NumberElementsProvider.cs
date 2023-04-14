using Polish.NumbersInWords.NumberInWordsProviders;
using Polish.NumbersInWords.PhraseAfterNumberProviders;

namespace Polish.NumbersInWords
{
    internal class NumberElementsProvider : INumberElementsProvider
    {
        private readonly INumberInWordsProviderFactory _numberInWordsProviderFactory;
        private readonly IPhraseAfterNumberProviderFactory _phraseAfterNumberProviderFactory;

        public NumberElementsProvider()
        {
            _numberInWordsProviderFactory = new NumberInWordsProviderFactory();
            _phraseAfterNumberProviderFactory = new PhraseAfterNumberProviderFactory();
        }

        public NumberElementsProvider(INumberInWordsProviderFactory numberInWordsProviderFactory, IPhraseAfterNumberProviderFactory phraseAfterNumberProviderFactory)
        {
            _numberInWordsProviderFactory = numberInWordsProviderFactory ?? throw new System.ArgumentNullException(nameof(numberInWordsProviderFactory));
            _phraseAfterNumberProviderFactory = phraseAfterNumberProviderFactory ?? throw new System.ArgumentNullException(nameof(phraseAfterNumberProviderFactory));
        }

        public INumberElements Provide(long number)
        {
            return Provide(number, NumberProperties.CreateDefault());
        }

        public INumberElements Provide(long number, NumberProperties numberProperties)
        {
            return Provide(number, numberProperties, new NumberInWordsConfiguration());
        }

        public INumberElements Provide(long number, NumberProperties numberProperties, INumberInWordsConfiguration configuration)
        {
            var numberInWordsProvider = _numberInWordsProviderFactory.Create(numberProperties, configuration);
            var phraseAfterNumberProvider = _phraseAfterNumberProviderFactory.Create(numberProperties);

            return new NumberElements(number, numberInWordsProvider, phraseAfterNumberProvider);
        }
    }
}
