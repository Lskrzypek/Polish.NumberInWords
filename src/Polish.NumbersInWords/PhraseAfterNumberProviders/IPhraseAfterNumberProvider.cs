namespace Polish.NumbersInWords.PhraseAfterNumberProviders
{
    internal interface IPhraseAfterNumberProvider
    {
        string Provide(long number, IPhrase phrase);
    }
}
