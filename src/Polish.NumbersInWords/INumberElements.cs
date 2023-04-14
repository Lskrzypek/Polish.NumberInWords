namespace Polish.NumbersInWords
{
    /// <summary>
    /// Number elements with the number in words and methods to manipulate it.
    /// </summary>
    public interface INumberElements
    {
        /// <summary>
        /// Original number
        /// </summary>
        long Number { get; }

        /// <summary>
        /// Number in words
        /// </summary>
        string Words { get; }

        /// <summary>
        /// Returns specific phrase declension.
        /// </summary>
        string GetPhraseAfterNumber(IPhrase phrase);
    }
}
