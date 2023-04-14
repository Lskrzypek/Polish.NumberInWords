using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Plural;
using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Singular;
using Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal.Core;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal
{
    internal class NeuterNominative : INeuterNominative
    {
        private readonly ICardinalNumberProviderFactory _cardinalNumberProviderFactory;
        private readonly ISingularNeuterNominative _neuterNominative;
        private readonly ISingularMasculineNominative _masculineNominative;
        private readonly IPluralNominative _pluralNominative;
        private readonly IPluralGenitive _pluralGenitive;

        public NeuterNominative(ICardinalNumberProviderFactory cardinalNumberProviderFactory,
                          ISingularNeuterNominative neuterNominative,
                          ISingularMasculineNominative masculineNominative,
                          IPluralNominative pluralNominative,
                          IPluralGenitive pluralGenitive)
        {
            _cardinalNumberProviderFactory = cardinalNumberProviderFactory ?? throw new System.ArgumentNullException(nameof(cardinalNumberProviderFactory));
            _neuterNominative = neuterNominative ?? throw new System.ArgumentNullException(nameof(neuterNominative));
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
                    basicNumbers: _neuterNominative,
                    from_2_to_4_thousands: _pluralNominative,
                    up_to_4_thousands: _pluralGenitive,
                    a_1_on_end: _masculineNominative,
                    count_of_thousands: _masculineNominative);
        }

        public static NeuterNominative Create(INumberInWordsConfiguration configuration)
        {
            return new NeuterNominative(
                        new CardinalNumberProviderFactory(new NumberSeparator(), configuration),
                        new SingularNeuterNominative(),
                        new SingularMasculineNominative(),
                        new PluralNominative(),
                        new PluralGenitive());
        }
    }
}
