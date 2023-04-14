using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Ordinal;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal class NeuterGenitive : INeuterGenitive
    {
        private readonly INeuter<ISingularNeuterGenitive> _ordinalNeuter;

        public NeuterGenitive(INeuter<ISingularNeuterGenitive> ordinalNeuter)
        {
            _ordinalNeuter = ordinalNeuter ?? throw new System.ArgumentNullException(nameof(ordinalNeuter));
        }

        public string Provide(long number)
        {
            return _ordinalNeuter.Provide(number);
        }

        public static NeuterGenitive Create(INumberInWordsConfiguration configuration)
        {
            var ordinalNeuter = Neuter<ISingularNeuterGenitive>.Create<SingularNeuterGenitive>(configuration);
            return new NeuterGenitive(ordinalNeuter);
        }
    }
}
