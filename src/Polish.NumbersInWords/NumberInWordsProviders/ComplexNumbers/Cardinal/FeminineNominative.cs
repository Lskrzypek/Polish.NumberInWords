using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Plural;
using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Singular;
using Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal.Core;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal
{
    internal class FeminineNominative : IFeminineNominative
    {
        private readonly ICardinalNumberProviderFactory _cardinalNumberProviderFactory;
        private readonly ISingularFeminineNominative _feminineNominative;
        private readonly ISingularMasculineNominative _masculineNominative;
        private readonly IPluralNominative _pluralNominative;
        private readonly IPluralGenitive _pluralGenitive;

        public FeminineNominative(ICardinalNumberProviderFactory cardinalNumberProviderFactory,
                          ISingularFeminineNominative feminineNominative,
                          ISingularMasculineNominative masculineNominative,
                          IPluralNominative pluralNominative,
                          IPluralGenitive pluralGenitive)
        {
            _cardinalNumberProviderFactory = cardinalNumberProviderFactory ?? throw new System.ArgumentNullException(nameof(cardinalNumberProviderFactory));
            _feminineNominative = feminineNominative ?? throw new System.ArgumentNullException(nameof(feminineNominative));
            _masculineNominative = masculineNominative ?? throw new System.ArgumentNullException(nameof(masculineNominative));
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
                    basicNumbers: _feminineNominative,
                    from_2_to_4_thousands: _pluralNominative,
                    up_to_4_thousands: _pluralGenitive,
                    a_1_on_end: _masculineNominative,
                    count_of_thousands: _masculineNominative);
        }

        public static FeminineNominative Create(INumberInWordsConfiguration configuration)
        {
            return new FeminineNominative(
                        new CardinalNumberProviderFactory(new NumberSeparator(), configuration),
                        new SingularFeminineNominative(),
                        new SingularMasculineNominative(),
                        new PluralNominative(),
                        new PluralGenitive());
        }
    }
}
