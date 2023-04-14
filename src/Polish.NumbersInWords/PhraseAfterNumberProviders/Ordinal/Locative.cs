namespace Polish.NumbersInWords.PhraseAfterNumberProviders.Ordinal
{
    internal class Locative : ILocative
    {
        public string Provide(long number, IPhrase phrase)
        {
            return phrase.LocativeForm;
        }
    }
}
