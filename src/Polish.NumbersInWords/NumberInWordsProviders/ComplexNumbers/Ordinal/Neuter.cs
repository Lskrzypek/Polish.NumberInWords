using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers;
using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Plural;
using Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal.Core;
using Cardinals = Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    internal class Neuter<TBasicNumbers> : INeuter<TBasicNumbers>
        where TBasicNumbers : ISimpleNumbers
    {
        private readonly IOrdinalNumberProviderFactory _ordinalNumberProviderFactory;
        private readonly TBasicNumbers _ordinalBasic;
        private readonly Cardinals.Singular.ISingularNeuterNominative _cardinalNominative;
        private readonly IPluralNominative _cardinalPluralNominative;
        private readonly IPluralGenitive _cardinalPluralGenitive;

        public Neuter(IOrdinalNumberProviderFactory ordinalNumberProviderFactory,
                                 TBasicNumbers ordinalBasic,
                                 Cardinals.Singular.ISingularNeuterNominative cardinalNominative,
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

        public static Neuter<TBasicNumbers> Create<TBasicNumbersImplementation>(INumberInWordsConfiguration configuration)
            where TBasicNumbersImplementation : TBasicNumbers, new()
        {
            return new Neuter<TBasicNumbers>(
                        new OrdinalNumberProviderFactory(new NumberSeparator(), new BigNumbersPrefixes(), configuration),
                        new TBasicNumbersImplementation(),
                        new Cardinals.Singular.SingularNeuterNominative(),
                        new PluralNominative(),
                        new PluralGenitive());
        }
    }
}
