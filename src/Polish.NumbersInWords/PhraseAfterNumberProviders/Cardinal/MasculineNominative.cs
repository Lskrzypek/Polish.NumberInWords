namespace Polish.NumbersInWords.PhraseAfterNumberProviders.Cardinal
{
    internal class MasculineNominative : IMasculineNominative
    {
        public string Provide(long number, IPhrase phrase)
        {
            if (number == 1)
                return phrase.NominativeForm;

            var lastDig = number % 10;
            var last2digs = number % 100;

            if (lastDig >= 2 && lastDig <= 4 && (last2digs > 20 || last2digs < 10))
                return phrase.PluralNominativeForm;

            return phrase.PluralGenitiveForm;
        }
    }
}
