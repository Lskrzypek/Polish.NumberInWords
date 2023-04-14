namespace Polish.NumbersInWords.NumberInWordsProviders
{
    internal interface INumberInWordsProviderFactory
    {
        INumberInWordsProvider Create(NumberProperties numberProperties, INumberInWordsConfiguration configuration);
    }
}
