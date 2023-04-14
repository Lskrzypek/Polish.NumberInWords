using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Plural;
using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Singular;
using Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal.Core;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal
{
    internal class FeminineInstrumental : IFeminineInstrumental
    {
        private readonly ICardinalNumberProviderFactory _cardinalNumberSolverFactory;
        private readonly ISingularFeminineInstrumental _feminineInstrumental;
        private readonly ISingularMasculineInstrumental _masculineInstrumental;
        private readonly ISingularMasculineNominative _nominative;
        private readonly IPluralInstrumental _pluralInstrumental;

        public FeminineInstrumental(ICardinalNumberProviderFactory cardinalNumberSolverFactory,
                                     ISingularFeminineInstrumental feminineInstrumental,
                                     ISingularMasculineInstrumental masculineInstrumental,
                                     ISingularMasculineNominative nominative,
                                     IPluralInstrumental pluralInstrumental)
        {
            _cardinalNumberSolverFactory = cardinalNumberSolverFactory ?? throw new System.ArgumentNullException(nameof(cardinalNumberSolverFactory));
            _feminineInstrumental = feminineInstrumental ?? throw new System.ArgumentNullException(nameof(feminineInstrumental));
            _masculineInstrumental = masculineInstrumental ?? throw new System.ArgumentNullException(nameof(masculineInstrumental));
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
                    basicNumbers: _feminineInstrumental,
                    from_2_to_4_thousands: _pluralInstrumental,
                    up_to_4_thousands: _pluralInstrumental,
                    a_1_on_end: _nominative,
                    count_of_thousands: _masculineInstrumental);
        }

        public static FeminineInstrumental Create(INumberInWordsConfiguration configuration)
        {
            return new FeminineInstrumental(
                        new CardinalNumberProviderFactory(new NumberSeparator(), configuration),
                        new SingularFeminineInstrumental(),
                        new SingularMasculineInstrumental(),
                        new SingularMasculineNominative(),
                        new PluralInstrumental());
        }
    }
}
