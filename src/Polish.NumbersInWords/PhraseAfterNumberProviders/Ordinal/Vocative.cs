namespace Polish.NumbersInWords.PhraseAfterNumberProviders.Ordinal
{
    internal class Vocative : IVocative
    {
        public string Provide(long number, IPhrase phrase)
        {
            return phrase.VocativeForm;
        }
    }
}
