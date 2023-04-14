namespace Polish.NumbersInWords
{
    /// <summary>
    /// Provide a number elements for a number
    /// </summary>
    public interface INumberElementsProvider
    {
        /// <summary>
        /// Provide a number elements for a number
        /// </summary>
        INumberElements Provide(long number);

        /// <summary>
        /// Provide a number elements for a number
        /// </summary>
        INumberElements Provide(long number, NumberProperties numberProperties);

        /// <summary>
        /// Provide a number elements for a number
        /// </summary>
        INumberElements Provide(long number, NumberProperties numberProperties, INumberInWordsConfiguration configuration);
    }
}
