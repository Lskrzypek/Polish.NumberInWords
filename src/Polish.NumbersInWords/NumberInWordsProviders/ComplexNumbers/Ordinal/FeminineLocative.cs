using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Ordinal;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal class FeminineLocative : IFeminineLocative
    {
        private readonly IFeminine<ISingularFeminineLocative> _ordinalFeminine;

        public FeminineLocative(IFeminine<ISingularFeminineLocative> ordinalFeminine)
        {
            _ordinalFeminine = ordinalFeminine ?? throw new System.ArgumentNullException(nameof(ordinalFeminine));
        }

        public string Provide(long number)
        {
            return _ordinalFeminine.Provide(number);
        }

        public static FeminineLocative Create(INumberInWordsConfiguration configuration)
        {
            var ordinalFeminine = Feminine<ISingularFeminineLocative>.Create<SingularFeminineLocative>(configuration);
            return new FeminineLocative(ordinalFeminine);
        }
    }
}
