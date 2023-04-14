namespace Polish.NumbersInWords.PhraseAfterNumberProviders.Ordinal
{
    internal class Instrumental : IInstrumental
    {
        public string Provide(long number, IPhrase phrase)
        {
            return phrase.InstrumentalForm;
        }
    }
}
