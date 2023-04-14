using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Plural;
using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Singular;
using Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal.Core;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal
{
    internal class FeminineLocative : IFeminineLocative
    {
        private readonly ICardinalNumberProviderFactory _cardinalNumberSolverFactory;
        private readonly ISingularFeminineLocative _feminineLocative;
        private readonly ISingularMasculineLocative _masculineLocative;
        private readonly ISingularMasculineNominative _nominative;
        private readonly IPluralLocative _pluralLocative;

        public FeminineLocative(ICardinalNumberProviderFactory cardinalNumberSolverFactory,
                                 ISingularFeminineLocative feminineLocative,
                                 ISingularMasculineLocative masculineLocative,
                                 ISingularMasculineNominative nominative,
                                 IPluralLocative pluralLocative)
        {
            _cardinalNumberSolverFactory = cardinalNumberSolverFactory ?? throw new System.ArgumentNullException(nameof(cardinalNumberSolverFactory));
            _feminineLocative = feminineLocative ?? throw new System.ArgumentNullException(nameof(feminineLocative));
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
                    basicNumbers: _feminineLocative,
                    from_2_to_4_thousands: _pluralLocative,
                    up_to_4_thousands: _pluralLocative,
                    a_1_on_end: _nominative,
                    count_of_thousands: _masculineLocative);
        }

        public static FeminineLocative Create(INumberInWordsConfiguration configuration)
        {
            return new FeminineLocative(
                        new CardinalNumberProviderFactory(new NumberSeparator(), configuration),
                        new SingularFeminineLocative(),
                        new SingularMasculineLocative(),
                        new SingularMasculineNominative(),
                        new PluralLocative());
        }
    }
}
