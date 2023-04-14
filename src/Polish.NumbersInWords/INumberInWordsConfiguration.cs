namespace Polish.NumbersInWords
{
    /// <summary>
    /// Configuration for <see cref="NumberElementsBuilder"/>
    /// </summary>
    public interface INumberInWordsConfiguration
    {
        /// <summary>
        /// If it is <see langword="true"/> then the number in words have "one" before big numbers. For example 1008 will be convert to "jeden tysiąc osiem", not just "tysiąc osiem".
        /// </summary>
        bool OneBeforeThousand { get; set; }
    }
}
