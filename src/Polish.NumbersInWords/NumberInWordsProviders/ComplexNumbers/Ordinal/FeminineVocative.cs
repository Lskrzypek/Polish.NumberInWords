using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Ordinal;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal class FeminineVocative : IFeminineVocative
    {
        private readonly IFeminine<ISingularFeminineVocative> _ordinalFeminine;

        public FeminineVocative(IFeminine<ISingularFeminineVocative> ordinalFeminine)
        {
            _ordinalFeminine = ordinalFeminine ?? throw new System.ArgumentNullException(nameof(ordinalFeminine));
        }

        public string Provide(long number)
        {
            return _ordinalFeminine.Provide(number);
        }

        public static FeminineVocative Create(INumberInWordsConfiguration configuration)
        {
            var ordinalFeminine = Feminine<ISingularFeminineVocative>.Create<SingularFeminineVocative>(configuration);
            return new FeminineVocative(ordinalFeminine);
        }
    }
}
