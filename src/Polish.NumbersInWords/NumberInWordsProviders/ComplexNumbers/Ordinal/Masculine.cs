using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers;
using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Plural;
using Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal.Core;
using Cardinals = Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal class Masculine<TBasicNumbers> : IMasculine<TBasicNumbers>
        where TBasicNumbers : ISimpleNumbers
    {
        private readonly IOrdinalNumberProviderFactory _ordinalNumberProviderFactory;
        private readonly TBasicNumbers _ordinalBasic;
        private readonly Cardinals.Singular.ISingularMasculineNominative _cardinalNominative;
        private readonly IPluralNominative _cardinalPluralNominative;
        private readonly IPluralGenitive _cardinalPluralGenitive;

        public Masculine(IOrdinalNumberProviderFactory ordinalNumberProviderFactory,
                                 TBasicNumbers ordinalBasic,
                                 Cardinals.Singular.ISingularMasculineNominative cardinalNominative,
                                 IPluralNominative cardinalPluralNominative,
                                 IPluralGenitive cardinalPluralGenitive)
        {
            _ordinalNumberProviderFactory = ordinalNumberProviderFactory ?? throw new System.ArgumentNullException(nameof(ordinalNumberProviderFactory));
            _ordinalBasic = ordinalBasic;
            _cardinalNominative = cardinalNominative ?? throw new System.ArgumentNullException(nameof(cardinalNominative));
            _cardinalPluralNominative = cardinalPluralNominative ?? throw new System.ArgumentNullException(nameof(cardinalPluralNominative));
            _cardinalPluralGenitive = cardinalPluralGenitive ?? throw new System.ArgumentNullException(nameof(cardinalPluralGenitive));
        }

        public string Provide(long number)
        {
            return CreateProvider().Provide(number);
        }

        private IOrdinalNumberProvider CreateProvider()
        {
            return _ordinalNumberProviderFactory.Create(
                basicOrdinalNumbers: _ordinalBasic,
                basicCardinalNumbers: _cardinalNominative,
                from_2_to_4_thousands: _cardinalPluralNominative,
                up_to_4_thousands: _cardinalPluralGenitive,
                hundreds: _cardinalNominative);
        }

        public static Masculine<TBasicNumbers> Create<TBasicNumbersImplementation>(INumberInWordsConfiguration configuration)
            where TBasicNumbersImplementation : TBasicNumbers, new()
        {
            return new Masculine<TBasicNumbers>(
                        new OrdinalNumberProviderFactory(new NumberSeparator(), new BigNumbersPrefixes(), configuration),
                        new TBasicNumbersImplementation(),
                        new Cardinals.Singular.SingularMasculineNominative(),
                        new PluralNominative(),
                        new PluralGenitive());
        }
    }
}
