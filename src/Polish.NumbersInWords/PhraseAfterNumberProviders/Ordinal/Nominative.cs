namespace Polish.NumbersInWords.PhraseAfterNumberProviders.Ordinal
{
    internal class Nominative : INominative
    {
        public string Provide(long number, IPhrase phrase)
        {
            return phrase.NominativeForm;
        }
    }
}
