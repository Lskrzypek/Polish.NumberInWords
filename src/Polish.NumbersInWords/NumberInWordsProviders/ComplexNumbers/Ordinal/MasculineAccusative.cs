using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Ordinal;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal class MasculineAccusative : IMasculineAccusative
    {
        private readonly IMasculine<ISingularMasculineAccusative> _ordinalMasculine;

        public MasculineAccusative(IMasculine<ISingularMasculineAccusative> ordinalMasculine)
        {
            _ordinalMasculine = ordinalMasculine ?? throw new System.ArgumentNullException(nameof(ordinalMasculine));
        }

        public string Provide(long number)
        {
            return _ordinalMasculine.Provide(number);
        }

        public static MasculineAccusative Create(INumberInWordsConfiguration configuration)
        {
            var ordinalMasculine = Masculine<ISingularMasculineAccusative>.Create<SingularMasculineAccusative>(configuration);
            return new MasculineAccusative(ordinalMasculine);
        }
    }
}
