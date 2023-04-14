using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Ordinal;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal class FeminineGenitive : IFeminineGenitive
    {
        private readonly IFeminine<ISingularFeminineGenitive> _ordinalFeminine;

        public FeminineGenitive(IFeminine<ISingularFeminineGenitive> ordinalFeminine)
        {
            _ordinalFeminine = ordinalFeminine ?? throw new System.ArgumentNullException(nameof(ordinalFeminine));
        }

        public string Provide(long number)
        {
            return _ordinalFeminine.Provide(number);
        }

        public static FeminineGenitive Create(INumberInWordsConfiguration configuration)
        {
            var ordinalFeminine = Feminine<ISingularFeminineGenitive>.Create<SingularFeminineGenitive>(configuration);
            return new FeminineGenitive(ordinalFeminine);
        }
    }
}
