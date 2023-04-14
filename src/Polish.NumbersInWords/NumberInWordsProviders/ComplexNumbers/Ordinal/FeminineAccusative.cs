using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Ordinal;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal class FeminineAccusative : IFeminineAccusative
    {
        private readonly IFeminine<ISingularFeminineAccusative> _ordinalFeminine;

        public FeminineAccusative(IFeminine<ISingularFeminineAccusative> ordinalFeminine)
        {
            _ordinalFeminine = ordinalFeminine ?? throw new System.ArgumentNullException(nameof(ordinalFeminine));
        }

        public string Provide(long number)
        {
            return _ordinalFeminine.Provide(number);
        }

        public static FeminineAccusative Create(INumberInWordsConfiguration configuration)
        {
            var ordinalFeminine = Feminine<ISingularFeminineAccusative>.Create<SingularFeminineAccusative>(configuration);
            return new FeminineAccusative(ordinalFeminine);
        }
    }
}
