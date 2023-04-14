using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Ordinal;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal class MasculineInstrumental : IMasculineInstrumental
    {
        private readonly IMasculine<ISingularMasculineInstrumental> _ordinalMasculine;

        public MasculineInstrumental(IMasculine<ISingularMasculineInstrumental> ordinalMasculine)
        {
            _ordinalMasculine = ordinalMasculine ?? throw new System.ArgumentNullException(nameof(ordinalMasculine));
        }

        public string Provide(long number)
        {
            return _ordinalMasculine.Provide(number);
        }

        public static MasculineInstrumental Create(INumberInWordsConfiguration configuration)
        {
            var ordinalMasculine = Masculine<ISingularMasculineInstrumental>.Create<SingularMasculineInstrumental>(configuration);
            return new MasculineInstrumental(ordinalMasculine);
        }
    }
}
