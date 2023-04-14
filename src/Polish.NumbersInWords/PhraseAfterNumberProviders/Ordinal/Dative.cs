namespace Polish.NumbersInWords.PhraseAfterNumberProviders.Ordinal
{
    internal class Dative : IDative
    {
        public string Provide(long number, IPhrase phrase)
        {
            return phrase.DativeForm;
        }
    }
}
