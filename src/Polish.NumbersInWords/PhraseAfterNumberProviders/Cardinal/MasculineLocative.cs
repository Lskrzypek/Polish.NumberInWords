using System.Linq;

namespace Polish.NumbersInWords.PhraseAfterNumberProviders.Cardinal
{
    internal class MasculineLocative : IMasculineLocative
    {
        public string Provide(long number, IPhrase phrase)
        {
            if (number == 0)
                return phrase.PluralGenitiveForm;

            if (number == 1)
                return phrase.LocativeForm;

            if (number % 1000 == 0 || number % 10001 == 0)
                return phrase.PluralGenitiveForm;

            return phrase.PluralLocativeForm;
        }
    }
}
