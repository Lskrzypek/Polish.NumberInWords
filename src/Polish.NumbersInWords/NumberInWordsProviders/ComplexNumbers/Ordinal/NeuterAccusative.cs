using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Ordinal;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal class NeuterAccusative : INeuterAccusative
    {
        private readonly INeuter<ISingularNeuterAccusative> _ordinalNeuter;

        public NeuterAccusative(INeuter<ISingularNeuterAccusative> ordinalNeuter)
        {
            _ordinalNeuter = ordinalNeuter ?? throw new System.ArgumentNullException(nameof(ordinalNeuter));
        }

        public string Provide(long number)
        {
            return _ordinalNeuter.Provide(number);
        }

        public static NeuterAccusative Create(INumberInWordsConfiguration configuration)
        {
            var ordinalNeuter = Neuter<ISingularNeuterAccusative>.Create<SingularNeuterAccusative>(configuration);
            return new NeuterAccusative(ordinalNeuter);
        }
    }
}
