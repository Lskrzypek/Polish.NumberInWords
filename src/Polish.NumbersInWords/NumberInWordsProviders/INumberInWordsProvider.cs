using Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal.Core;

namespace Polish.NumbersInWords.NumberInWordsProviders
{
    internal interface INumberInWordsProvider
    {
        string Provide(long number);
    }
}
