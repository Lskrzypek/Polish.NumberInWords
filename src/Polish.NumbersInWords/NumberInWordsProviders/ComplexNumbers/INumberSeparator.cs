namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers
{
    internal interface INumberSeparator
    {
        NumberElements Separate(long number);
    }
}