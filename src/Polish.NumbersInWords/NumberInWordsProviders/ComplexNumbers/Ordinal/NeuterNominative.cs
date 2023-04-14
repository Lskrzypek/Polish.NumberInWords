using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Ordinal;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal class NeuterNominative : INeuterNominative
    {
        private readonly INeuter<ISingularNeuterNominative> _ordinalNeuter;

        public NeuterNominative(INeuter<ISingularNeuterNominative> ordinalNeuter)
        {
            _ordinalNeuter = ordinalNeuter ?? throw new System.ArgumentNullException(nameof(ordinalNeuter));
        }

        public string Provide(long number)
        {
            return _ordinalNeuter.Provide(number);
        }

        public static NeuterNominative Create(INumberInWordsConfiguration configuration)
        {
            var ordinalNeuter = Neuter<ISingularNeuterNominative>.Create<SingularNeuterNominative>(configuration);
            return new NeuterNominative(ordinalNeuter);
        }
    }
}
