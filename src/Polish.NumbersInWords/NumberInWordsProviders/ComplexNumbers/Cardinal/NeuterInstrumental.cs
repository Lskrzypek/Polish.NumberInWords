using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Plural;
using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Singular;
using Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal.Core;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal
{
    internal class NeuterInstrumental : INeuterInstrumental
    {
        private readonly ICardinalNumberProviderFactory _cardinalNumberSolverFactory;
        private readonly ISingularNeuterInstrumental _neuterInstrumental;
        private readonly ISingularMasculineInstrumental _masculineInstrumental;
        private readonly ISingularMasculineNominative _nominative;
        private readonly IPluralInstrumental _pluralInstrumental;

        public NeuterInstrumental(ICardinalNumberProviderFactory cardinalNumberSolverFactory,
                                     ISingularNeuterInstrumental neuterInstrumental,
                                     ISingularMasculineInstrumental masculineInstrumental,
                                     ISingularMasculineNominative nominative,
                                     IPluralInstrumental pluralInstrumental)
        {
            _cardinalNumberSolverFactory = cardinalNumberSolverFactory ?? throw new System.ArgumentNullException(nameof(cardinalNumberSolverFactory));
            _neuterInstrumental = neuterInstrumental ?? throw new System.ArgumentNullException(nameof(neuterInstrumental));
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
                    basicNumbers: _neuterInstrumental,
                    from_2_to_4_thousands: _pluralInstrumental,
                    up_to_4_thousands: _pluralInstrumental,
                    a_1_on_end: _nominative,
                    count_of_thousands: _masculineInstrumental);
        }

        public static NeuterInstrumental Create(INumberInWordsConfiguration configuration)
        {
            return new NeuterInstrumental(
                        new CardinalNumberProviderFactory(new NumberSeparator(), configuration),
                        new SingularNeuterInstrumental(),
                        new SingularMasculineInstrumental(),
                        new SingularMasculineNominative(),
                        new PluralInstrumental());
        }
    }
}
