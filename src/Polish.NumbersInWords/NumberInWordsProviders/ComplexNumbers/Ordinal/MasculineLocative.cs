using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Ordinal;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal class MasculineLocative : IMasculineLocative
    {
        private readonly IMasculine<ISingularMasculineLocative> _ordinalMasculine;

        public MasculineLocative(IMasculine<ISingularMasculineLocative> ordinalMasculine)
        {
            _ordinalMasculine = ordinalMasculine ?? throw new System.ArgumentNullException(nameof(ordinalMasculine));
        }

        public string Provide(long number)
        {
            return _ordinalMasculine.Provide(number);
        }

        public static MasculineLocative Create(INumberInWordsConfiguration configuration)
        {
            var ordinalMasculine = Masculine<ISingularMasculineLocative>.Create<SingularMasculineLocative>(configuration);
            return new MasculineLocative(ordinalMasculine);
        }
    }
}
