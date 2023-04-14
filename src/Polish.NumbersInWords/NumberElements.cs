using Polish.NumbersInWords.NumberInWordsProviders;
using Polish.NumbersInWords.PhraseAfterNumberProviders;

namespace Polish.NumbersInWords
{
    internal class NumberElements : INumberElements
    {
        public long Number { get; private set; }

        private string _words = null;
        public string Words
        {
            get
            {
                if (_words == null)
                {
                    _words = _numberInWordsProvider.Provide(Number);
                }

                return _words;
            }
        }

        private readonly INumberInWordsProvider _numberInWordsProvider;
        private readonly IPhraseAfterNumberProvider _phraseAfterNumberProvider;


        public NumberElements(
            long number,
            INumberInWordsProvider numberInWordsProvider,
            IPhraseAfterNumberProvider phraseAfterNumberProvider)
        {
            Number = number;

            _numberInWordsProvider = numberInWordsProvider ?? throw new System.ArgumentNullException(nameof(numberInWordsProvider));
            _phraseAfterNumberProvider = phraseAfterNumberProvider ?? throw new System.ArgumentNullException(nameof(phraseAfterNumberProvider));
        }

        public string GetPhraseAfterNumber(IPhrase phrase)
        {
            return _phraseAfterNumberProvider.Provide(Number, phrase);
        }

        public override string ToString() => Words;
    }
}
