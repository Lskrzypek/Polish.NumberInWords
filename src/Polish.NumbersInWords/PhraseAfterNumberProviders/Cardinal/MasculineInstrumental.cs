using System.Linq;

namespace Polish.NumbersInWords.PhraseAfterNumberProviders.Cardinal
{
    internal class MasculineInstrumental : IMasculineInstrumental
    {
        public string Provide(long number, IPhrase phrase)
        {
            if (number == 0)
                return phrase.PluralGenitiveForm;

            if (number == 1)
                return phrase.InstrumentalForm;

            if (number % 1000 == 0 || number % 10001 == 0)
                return phrase.PluralGenitiveForm;

            return phrase.PluralInstrumentalForm;
        }
    }
}
