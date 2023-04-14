using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Plural;
using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Singular;
using Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal.Core;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal
{
    internal class MasculineInstrumental : IMasculineInstrumental
    {
        private readonly ICardinalNumberProviderFactory _cardinalNumberSolverFactory;
        private readonly ISingularMasculineInstrumental _instrumental;
        private readonly ISingularMasculineNominative _nominative;
        private readonly IPluralInstrumental _pluralInstrumental;

        public MasculineInstrumental(ICardinalNumberProviderFactory cardinalNumberSolverFactory,
                                     ISingularMasculineInstrumental instrumental,
                                     ISingularMasculineNominative nominative,
                                     IPluralInstrumental pluralInstrumental)
        {
            _cardinalNumberSolverFactory = cardinalNumberSolverFactory ?? throw new System.ArgumentNullException(nameof(cardinalNumberSolverFactory));
            _instrumental = instrumental ?? throw new System.ArgumentNullException(nameof(instrumental));
            _nominative = nominative ?? throw new System.ArgumentNullException(nameof(nominative));
            _pluralInstrumental = pluralInstrumental ?? throw new System.ArgumentNullException(nameof(pluralInstrumental));
        }

        public string Provide(long number)
        {
            return CreateProvider().Provide(number);
        }

        private ICardinalNumberProvider CreateProvider()
        {
            return _cardinalNumberSolverFactory.Create(
                    basicNumbers: _instrumental,
                    from_2_to_4_thousands: _pluralInstrumental,
                    up_to_4_thousands: _pluralInstrumental,
                    a_1_on_end: _nominative,
                    count_of_thousands: _instrumental);
        }

        public static MasculineInstrumental Create(INumberInWordsConfiguration configuration)
        {
            return new MasculineInstrumental(
                        new CardinalNumberProviderFactory(new NumberSeparator(), configuration),
                        new SingularMasculineInstrumental(),
                        new SingularMasculineNominative(),
                        new PluralInstrumental());
        }
    }
}
