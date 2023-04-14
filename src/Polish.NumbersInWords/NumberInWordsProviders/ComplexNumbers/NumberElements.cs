namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers
{
    internal struct NumberElements
    {
        public int Last2digs { get; set; }
        public int Hundreds { get; set; }
        public (int PowerOf1000, int Count)[] Thousands { get; set; }
    }
}
