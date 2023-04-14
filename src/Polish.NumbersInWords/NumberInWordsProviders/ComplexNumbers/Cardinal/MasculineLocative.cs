using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Plural;
using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Singular;
using Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal.Core;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal
{
    internal class MasculineLocative : IMasculineLocative
    {
        private readonly ICardinalNumberProviderFactory _cardinalNumberSolverFactory;
        private readonly ISingularMasculineLocative _locative;
        private readonly ISingularMasculineNominative _nominative;
        private readonly IPluralLocative _pluralLocative;

        public MasculineLocative(ICardinalNumberProviderFactory cardinalNumberSolverFactory,
                                 ISingularMasculineLocative locative,
                                 ISingularMasculineNominative nominative,
                                 IPluralLocative pluralLocative)
        {
            _cardinalNumberSolverFactory = cardinalNumberSolverFactory ?? throw new System.ArgumentNullException(nameof(cardinalNumberSolverFactory));
            _locative = locative ?? throw new System.ArgumentNullException(nameof(locative));
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
                    basicNumbers: _locative,
                    from_2_to_4_thousands: _pluralLocative,
                    up_to_4_thousands: _pluralLocative,
                    a_1_on_end: _nominative,
                    count_of_thousands: _locative);
        }

        public static MasculineLocative Create(INumberInWordsConfiguration configuration)
        {
            return new MasculineLocative(
                        new CardinalNumberProviderFactory(new NumberSeparator(), configuration),
                        new SingularMasculineLocative(),
                        new SingularMasculineNominative(),
                        new PluralLocative());
        }
    }
}
