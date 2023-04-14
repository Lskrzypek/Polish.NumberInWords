namespace Polish.NumbersInWords.PhraseAfterNumberProviders
{
    internal interface IPhraseAfterNumberProviderFactory
    {
        IPhraseAfterNumberProvider Create(NumberProperties numberProperties);
    }
}
