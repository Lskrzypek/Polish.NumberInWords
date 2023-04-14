using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Ordinal;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal class FeminineDative : IFeminineDative
    {
        private readonly IFeminine<ISingularFeminineDative> _ordinalFeminine;

        public FeminineDative(IFeminine<ISingularFeminineDative> ordinalFeminine)
        {
            _ordinalFeminine = ordinalFeminine ?? throw new System.ArgumentNullException(nameof(ordinalFeminine));
        }

        public string Provide(long number)
        {
            return _ordinalFeminine.Provide(number);
        }

        public static FeminineDative Create(INumberInWordsConfiguration configuration)
        {
            var ordinalFeminine = Feminine<ISingularFeminineDative>.Create<SingularFeminineDative>(configuration);
            return new FeminineDative(ordinalFeminine);
        }
    }
}
