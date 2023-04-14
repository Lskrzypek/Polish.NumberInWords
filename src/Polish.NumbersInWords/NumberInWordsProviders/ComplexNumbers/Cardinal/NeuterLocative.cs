using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Plural;
using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Singular;
using Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal.Core;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal
{
    internal class NeuterLocative : INeuterLocative
    {
        private readonly ICardinalNumberProviderFactory _cardinalNumberSolverFactory;
        private readonly ISingularNeuterLocative _neuterLocative;
        private readonly ISingularMasculineLocative _masculineLocative;
        private readonly ISingularMasculineNominative _nominative;
        private readonly IPluralLocative _pluralLocative;

        public NeuterLocative(ICardinalNumberProviderFactory cardinalNumberSolverFactory,
                                 ISingularNeuterLocative neuterLocative,
                                 ISingularMasculineLocative masculineLocative,
                                 ISingularMasculineNominative nominative,
                                 IPluralLocative pluralLocative)
        {
            _cardinalNumberSolverFactory = cardinalNumberSolverFactory ?? throw new System.ArgumentNullException(nameof(cardinalNumberSolverFactory));
            _neuterLocative = neuterLocative ?? throw new System.ArgumentNullException(nameof(neuterLocative));
            _masculineLocative = masculineLocative ?? throw new System.ArgumentNullException(nameof(masculineLocative));
            _nominative = nominative ?? throw new System.ArgumentNullException(nameof(nominative));
            _pluralLocative = pluralLocative ?? throw new System.ArgumentNullException(nameof(pluralLocative));
        }

        public string Provide(long number)
        {
            return CreateProvider().Provide(number);
        }

        private ICardinalNumberProvider CreateProvider()
        {
            return _cardinalNumberSolverFactory.Create(
                    basicNumbers: _neuterLocative,
                    from_2_to_4_thousands: _pluralLocative,
                    up_to_4_thousands: _pluralLocative,
                    a_1_on_end: _nominative,
                    count_of_thousands: _masculineLocative);
        }

        public static NeuterLocative Create(INumberInWordsConfiguration configuration)
        {
            return new NeuterLocative(
                        new CardinalNumberProviderFactory(new NumberSeparator(), configuration),
                        new SingularNeuterLocative(),
                        new SingularMasculineLocative(),
                        new SingularMasculineNominative(),
                        new PluralLocative());
        }
    }
}
