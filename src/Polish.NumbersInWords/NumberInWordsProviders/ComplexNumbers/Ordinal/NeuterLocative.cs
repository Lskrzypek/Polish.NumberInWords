using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Ordinal;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal class NeuterLocative : INeuterLocative
    {
        private readonly INeuter<ISingularNeuterLocative> _ordinalNeuter;

        public NeuterLocative(INeuter<ISingularNeuterLocative> ordinalNeuter)
        {
            _ordinalNeuter = ordinalNeuter ?? throw new System.ArgumentNullException(nameof(ordinalNeuter));
        }

        public string Provide(long number)
        {
            return _ordinalNeuter.Provide(number);
        }

        public static NeuterLocative Create(INumberInWordsConfiguration configuration)
        {
            var ordinalNeuter = Neuter<ISingularNeuterLocative>.Create<SingularNeuterLocative>(configuration);
            return new NeuterLocative(ordinalNeuter);
        }
    }
}
