using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal interface IFeminine<TBasicNumbers>
        where TBasicNumbers : ISimpleNumbers
    {
        string Provide(long number);
    }
}
