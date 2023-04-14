using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Plural;
using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Singular;
using Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal.Core;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal
{
    internal class NeuterDative : INeuterDative
    {
        private readonly ICardinalNumberProviderFactory _cardinalNumberProviderFactory;
        private readonly ISingularNeuterDative _neuterDative;
        private readonly ISingularMasculineDative _masculineDative;
        private readonly ISingularMasculineNominative _nominative;
        private readonly IPluralDative _pluralDative;

        public NeuterDative(ICardinalNumberProviderFactory cardinalNumberProviderFactory,
                          ISingularNeuterDative neuterDative,
                          ISingularMasculineDative masculineDative,
                          ISingularMasculineNominative nominative,
                          IPluralDative pluralDative)
        {
            _cardinalNumberProviderFactory = cardinalNumberProviderFactory ?? throw new System.ArgumentNullException(nameof(cardinalNumberProviderFactory));
            _nominative = nominative ?? throw new System.ArgumentNullException(nameof(nominative));
            _neuterDative = neuterDative ?? throw new System.ArgumentNullException(nameof(neuterDative));
            _masculineDative = masculineDative ?? throw new System.ArgumentNullException(nameof(masculineDative));
            _pluralDative = pluralDative ?? throw new System.ArgumentNullException(nameof(pluralDative));
        }

        public string Provide(long number)
        {
            return CreateProvider().Provide(number);
        }

        private ICardinalNumberProvider CreateProvider()
        {
            return _cardinalNumberProviderFactory.Create(
                    basicNumbers: _neuterDative,
                    from_2_to_4_thousands: _pluralDative,
                    up_to_4_thousands: _pluralDative,
                    a_1_on_end: _nominative,
                    count_of_thousands: _masculineDative);
        }

        public static NeuterDative Create(INumberInWordsConfiguration configuration)
        {
            return new NeuterDative(
                        new CardinalNumberProviderFactory(new NumberSeparator(), configuration),
                        new SingularNeuterDative(),
                        new SingularMasculineDative(),
                        new SingularMasculineNominative(),
                        new PluralDative());
        }
    }
}
