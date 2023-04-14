using Polish.NumbersInWords.NumberInWordsProviders;
using Polish.NumbersInWords.PhraseAfterNumberProviders;

namespace Polish.NumbersInWords
{
    /// <summary>
    /// Extends <see langword="int" />, <see langword="long" /> and <see langword="short" /> to get a number in Polish words.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Returns the number in words in Polish. For example: 123 is conveted to "sto dwadzieścia trzy". Use fluent methods to set up number declension.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Returns fluent builder, where you can setup number declension.</returns>
        public static NumberElementsBuilder ToPolishWords(this long number)
        {
            return CreateBuilder(number);
        }

        /// <summary>
        /// Returns the number in words in Polish. For example: 123 is converted to "sto dwadzieścia trzy". Use fluent methods to set up number declension.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Returns fluent builder, where you can setup number declensions.</returns>
        public static NumberElementsBuilder ToPolishWords(this int number)
        {
            return CreateBuilder(number);
        }

        /// <summary>
        /// Returns the number in words in Polish. For example: 123 is converted to "sto dwadzieścia trzy". Use fluent methods to set up number declension.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Returns fluent builder, where you can setup number declensions.</returns>
        public static NumberElementsBuilder ToPolishWords(this short number)
        {
            return CreateBuilder(number);
        }

        private static NumberElementsBuilder CreateBuilder(long number)
        {
            var numberInWordsProviderFactory = new NumberInWordsProviderFactory();
            var phraseAfterNumberProviderFactory = new PhraseAfterNumberProviderFactory();
            var numberElementsProvider = new NumberElementsProvider(numberInWordsProviderFactory, phraseAfterNumberProviderFactory);

            return new NumberElementsBuilder(number, numberElementsProvider);
        }
    }
}
