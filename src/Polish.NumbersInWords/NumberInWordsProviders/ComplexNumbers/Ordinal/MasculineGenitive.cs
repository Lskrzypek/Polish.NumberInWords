using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Ordinal;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal class MasculineGenitive : IMasculineGenitive
    {
        private readonly IMasculine<ISingularMasculineGenitive> _ordinalMasculine;

        public MasculineGenitive(IMasculine<ISingularMasculineGenitive> ordinalMasculine)
        {
            _ordinalMasculine = ordinalMasculine ?? throw new System.ArgumentNullException(nameof(ordinalMasculine));
        }

        public string Provide(long number)
        {
            return _ordinalMasculine.Provide(number);
        }

        public static MasculineGenitive Create(INumberInWordsConfiguration configuration)
        {
            var ordinalMasculine = Masculine<ISingularMasculineGenitive>.Create<SingularMasculineGenitive>(configuration);
            return new MasculineGenitive(ordinalMasculine);
        }
    }
}
