using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Ordinal;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal class MasculineDative : IMasculineDative
    {
        private readonly IMasculine<ISingularMasculineDative> _ordinalMasculine;

        public MasculineDative(IMasculine<ISingularMasculineDative> ordinalMasculine)
        {
            _ordinalMasculine = ordinalMasculine ?? throw new System.ArgumentNullException(nameof(ordinalMasculine));
        }

        public string Provide(long number)
        {
            return _ordinalMasculine.Provide(number);
        }

        public static MasculineDative Create(INumberInWordsConfiguration configuration)
        {
            var ordinalMasculine = Masculine<ISingularMasculineDative>.Create<SingularMasculineDative>(configuration);
            return new MasculineDative(ordinalMasculine);
        }
    }
}
