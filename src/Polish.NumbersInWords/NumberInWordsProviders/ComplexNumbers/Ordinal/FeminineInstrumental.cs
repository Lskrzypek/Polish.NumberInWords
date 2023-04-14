using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Ordinal;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal class FeminineInstrumental : IFeminineInstrumental
    {
        private readonly IFeminine<ISingularFeminineInstrumental> _ordinalFeminine;

        public FeminineInstrumental(IFeminine<ISingularFeminineInstrumental> ordinalFeminine)
        {
            _ordinalFeminine = ordinalFeminine ?? throw new System.ArgumentNullException(nameof(ordinalFeminine));
        }

        public string Provide(long number)
        {
            return _ordinalFeminine.Provide(number);
        }

        public static FeminineInstrumental Create(INumberInWordsConfiguration configuration)
        {
            var ordinalFeminine = Feminine<ISingularFeminineInstrumental>.Create<SingularFeminineInstrumental>(configuration);
            return new FeminineInstrumental(ordinalFeminine);
        }
    }
}
