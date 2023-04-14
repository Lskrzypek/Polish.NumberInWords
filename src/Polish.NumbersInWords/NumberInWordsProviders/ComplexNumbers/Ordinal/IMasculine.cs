using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal interface IMasculine<TBasicNumbers>
        where TBasicNumbers : ISimpleNumbers
    {
        string Provide(long number);
    }
}
