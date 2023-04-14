using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Ordinal;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal class NeuterInstrumental : INeuterInstrumental
    {
        private readonly INeuter<ISingularNeuterInstrumental> _ordinalNeuter;

        public NeuterInstrumental(INeuter<ISingularNeuterInstrumental> ordinalNeuter)
        {
            _ordinalNeuter = ordinalNeuter ?? throw new System.ArgumentNullException(nameof(ordinalNeuter));
        }

        public string Provide(long number)
        {
            return _ordinalNeuter.Provide(number);
        }

        public static NeuterInstrumental Create(INumberInWordsConfiguration configuration)
        {
            var ordinalNeuter = Neuter<ISingularNeuterInstrumental>.Create<SingularNeuterInstrumental>(configuration);
            return new NeuterInstrumental(ordinalNeuter);
        }
    }
}
