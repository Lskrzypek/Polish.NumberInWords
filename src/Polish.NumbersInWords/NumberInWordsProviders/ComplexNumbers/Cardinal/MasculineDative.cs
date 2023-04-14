using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Plural;
using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Singular;
using Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal.Core;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal
{
    internal class MasculineDative : IMasculineDative
    {
        private readonly ICardinalNumberProviderFactory _cardinalNumberProviderFactory;
        private readonly ISingularMasculineNominative _nominative;
        private readonly ISingularMasculineDative _dative;
        private readonly IPluralDative _pluralDative;

        public MasculineDative(ICardinalNumberProviderFactory cardinalNumberProviderFactory,
                          ISingularMasculineDative dative,
                          ISingularMasculineNominative nominative,
                          IPluralDative pluralDative)
        {
            _cardinalNumberProviderFactory = cardinalNumberProviderFactory ?? throw new System.ArgumentNullException(nameof(cardinalNumberProviderFactory));
            _nominative = nominative ?? throw new System.ArgumentNullException(nameof(nominative));
            _dative = dative ?? throw new System.ArgumentNullException(nameof(dative));
            _pluralDative = pluralDative ?? throw new System.ArgumentNullException(nameof(pluralDative));
        }

        public string Provide(long number)
        {
            return CreateProvider().Provide(number);
        }

        private ICardinalNumberProvider CreateProvider()
        {
            return _cardinalNumberProviderFactory.Create(
                    basicNumbers: _dative,
                    from_2_to_4_thousands: _pluralDative,
                    up_to_4_thousands: _pluralDative,
                    a_1_on_end: _nominative,
                    count_of_thousands: _dative);
        }

        public static MasculineDative Create(INumberInWordsConfiguration configuration)
        {
            return new MasculineDative(
                        new CardinalNumberProviderFactory(new NumberSeparator(), configuration),
                        new SingularMasculineDative(),
                        new SingularMasculineNominative(),
                        new PluralDative());
        }
    }
}
