namespace Polish.NumbersInWords.PhraseAfterNumberProviders.Ordinal
{
    internal class Accusative : IAccusative
    {
        public string Provide(long number, IPhrase phrase)
        {
            return phrase.AccusativeForm;
        }
    }
}
