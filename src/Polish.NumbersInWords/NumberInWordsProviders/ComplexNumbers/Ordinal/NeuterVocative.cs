using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Ordinal;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal class NeuterVocative : INeuterVocative
    {
        private readonly INeuter<ISingularNeuterVocative> _ordinalNeuter;

        public NeuterVocative(INeuter<ISingularNeuterVocative> ordinalNeuter)
        {
            _ordinalNeuter = ordinalNeuter ?? throw new System.ArgumentNullException(nameof(ordinalNeuter));
        }

        public string Provide(long number)
        {
            return _ordinalNeuter.Provide(number);
        }

        public static NeuterVocative Create(INumberInWordsConfiguration configuration)
        {
            var ordinalNeuter = Neuter<ISingularNeuterVocative>.Create<SingularNeuterVocative>(configuration);
            return new NeuterVocative(ordinalNeuter);
        }
    }
}
