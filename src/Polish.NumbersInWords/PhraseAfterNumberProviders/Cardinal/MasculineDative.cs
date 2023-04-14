using System;
using System.Linq;

namespace Polish.NumbersInWords.PhraseAfterNumberProviders.Cardinal
{
    internal class MasculineDative : IMasculineDative
    {
        public string Provide(long number, IPhrase phrase)
        {
            if (number == 0)
                return phrase.PluralDativeForm;

            if (number == 1)
                return phrase.DativeForm;

            if (number % 1000 == 0 || number % 10001 == 0)
                return phrase.PluralGenitiveForm;

            return phrase.PluralDativeForm;
        }
    }
}
