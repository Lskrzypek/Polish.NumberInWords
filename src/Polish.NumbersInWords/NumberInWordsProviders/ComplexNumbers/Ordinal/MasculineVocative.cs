using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Ordinal;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal class MasculineVocative : IMasculineVocative
    {
        private readonly IMasculine<ISingularMasculineVocative> _ordinalMasculine;

        public MasculineVocative(IMasculine<ISingularMasculineVocative> ordinalMasculine)
        {
            _ordinalMasculine = ordinalMasculine ?? throw new System.ArgumentNullException(nameof(ordinalMasculine));
        }

        public string Provide(long number)
        {
            return _ordinalMasculine.Provide(number);
        }

        public static MasculineVocative Create(INumberInWordsConfiguration configuration)
        {
            var ordinalMasculine = Masculine<ISingularMasculineVocative>.Create<SingularMasculineVocative>(configuration);
            return new MasculineVocative(ordinalMasculine);
        }
    }
}
