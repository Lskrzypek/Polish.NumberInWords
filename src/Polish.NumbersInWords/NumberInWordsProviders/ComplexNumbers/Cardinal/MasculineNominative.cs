using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Plural;
using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Singular;
using Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal.Core;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal
{
    internal class MasculineNominative : IMasculineNominative
    {
        private readonly ICardinalNumberProviderFactory _cardinalNumberProviderFactory;
        private readonly ISingularMasculineNominative _nominative;
        private readonly IPluralNominative _pluralNominative;
        private readonly IPluralGenitive _pluralGenitive;

        public MasculineNominative(ICardinalNumberProviderFactory cardinalNumberProviderFactory,
                          ISingularMasculineNominative nominative,
                          IPluralNominative pluralNominative,
                          IPluralGenitive pluralGenitive)
        {
            _cardinalNumberProviderFactory = cardinalNumberProviderFactory ?? throw new System.ArgumentNullException(nameof(cardinalNumberProviderFactory));
            _nominative = nominative ?? throw new System.ArgumentNullException(nameof(nominative));
            _pluralNominative = pluralNominative ?? throw new System.ArgumentNullException(nameof(pluralNominative));
            _pluralGenitive = pluralGenitive ?? throw new System.ArgumentNullException(nameof(pluralGenitive));
        }

        public string Provide(long number)
        {
            return CreateProvider().Provide(number);
        }

        private ICardinalNumberProvider CreateProvider()
        {
            return _cardinalNumberProviderFactory.Create(
                    basicNumbers: _nominative,
                    from_2_to_4_thousands: _pluralNominative,
                    up_to_4_thousands: _pluralGenitive,
                    a_1_on_end: _nominative,
                    count_of_thousands: _nominative);
        }

        public static MasculineNominative Create(INumberInWordsConfiguration configuration)
        {
            return new MasculineNominative(
                        new CardinalNumberProviderFactory(new NumberSeparator(), configuration),
                        new SingularMasculineNominative(),
                        new PluralNominative(),
                        new PluralGenitive());
        }
    }
}
