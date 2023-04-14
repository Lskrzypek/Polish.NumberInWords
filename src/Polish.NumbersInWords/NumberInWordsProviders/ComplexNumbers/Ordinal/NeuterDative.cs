using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Ordinal;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal class NeuterDative : INeuterDative
    {
        private readonly INeuter<ISingularNeuterDative> _ordinalNeuter;

        public NeuterDative(INeuter<ISingularNeuterDative> ordinalNeuter)
        {
            _ordinalNeuter = ordinalNeuter ?? throw new System.ArgumentNullException(nameof(ordinalNeuter));
        }

        public string Provide(long number)
        {
            return _ordinalNeuter.Provide(number);
        }

        public static NeuterDative Create(INumberInWordsConfiguration configuration)
        {
            var ordinalNeuter = Neuter<ISingularNeuterDative>.Create<SingularNeuterDative>(configuration);
            return new NeuterDative(ordinalNeuter);
        }
    }
}
