using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Ordinal;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal class MasculineNominative : IMasculineNominative
    {
        private readonly IMasculine<ISingularMasculineNominative> _ordinalMasculine;

        public MasculineNominative(IMasculine<ISingularMasculineNominative> ordinalMasculine)
        {
            _ordinalMasculine = ordinalMasculine ?? throw new System.ArgumentNullException(nameof(ordinalMasculine));
        }

        public string Provide(long number)
        {
            return _ordinalMasculine.Provide(number);
        }

        public static MasculineNominative Create(INumberInWordsConfiguration configuration)
        {
            var ordinalMasculine = Masculine<ISingularMasculineNominative>.Create<SingularMasculineNominative>(configuration);
            return new MasculineNominative(ordinalMasculine);
        }
    }
}
