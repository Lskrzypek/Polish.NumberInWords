using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal.Core
{
    internal interface IOrdinalNumberProviderFactory
    {
        IOrdinalNumberProvider Create(ISimpleNumbers basicOrdinalNumbers,
            ISimpleNumbers basicCardinalNumbers,
            ISimpleNumbers from_2_to_4_thousands,
            ISimpleNumbers up_to_4_thousands,
            ISimpleNumbers hundreds);
    }
}
