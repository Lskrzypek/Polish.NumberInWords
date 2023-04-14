using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal.Core
{
    internal interface ICardinalNumberProviderFactory
    {
        ICardinalNumberProvider Create(
            ISimpleNumbers basicNumbers,
            ISimpleNumbers from_2_to_4_thousands,
            ISimpleNumbers up_to_4_thousands,
            ISimpleNumbers a_1_on_end,
            ISimpleNumbers count_of_thousands);
    }
}
