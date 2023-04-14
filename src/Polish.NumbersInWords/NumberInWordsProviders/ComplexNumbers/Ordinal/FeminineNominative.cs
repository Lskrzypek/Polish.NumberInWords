using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Ordinal;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal class FeminineNominative : IFeminineNominative
    {
        private readonly IFeminine<ISingularFeminineNominative> _ordinalFeminine;

        public FeminineNominative(IFeminine<ISingularFeminineNominative> ordinalFeminine)
        {
            _ordinalFeminine = ordinalFeminine ?? throw new System.ArgumentNullException(nameof(ordinalFeminine));
        }

        public string Provide(long number)
        {
            return _ordinalFeminine.Provide(number);
        }

        public static FeminineNominative Create(INumberInWordsConfiguration configuration)
        {
            var ordinalFeminine = Feminine<ISingularFeminineNominative>.Create<SingularFeminineNominative>(configuration);
            return new FeminineNominative(ordinalFeminine);
        }
    }
}
