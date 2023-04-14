using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal interface INeuter<TBasicNumbers>
        where TBasicNumbers : ISimpleNumbers
    {
        string Provide(long number);
    }
}
