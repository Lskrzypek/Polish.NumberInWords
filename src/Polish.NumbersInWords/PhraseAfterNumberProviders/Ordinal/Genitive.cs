namespace Polish.NumbersInWords.PhraseAfterNumberProviders.Ordinal
{
    internal class Genitive : IGenitive
    {
        public string Provide(long number, IPhrase phrase)
        {
            return phrase.GenitiveForm;
        }
    }
}
