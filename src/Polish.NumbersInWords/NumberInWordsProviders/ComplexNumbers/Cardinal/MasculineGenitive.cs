using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Plural;
using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Singular;
using Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal.Core;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal
{
    internal class MasculineGenitive : IMasculineGenitive
    {
        private readonly ICardinalNumberProviderFactory _cardinalNumberSolverFactory;
        private readonly ISingularMasculineGenitive _genitive;
        private readonly ISingularMasculineNominative _nominative;
        private readonly IPluralGenitive _pluralGenitive;

        public MasculineGenitive(ICardinalNumberProviderFactory cardinalNumberSolverFactory,
                          ISingularMasculineGenitive genitive,
                          ISingularMasculineNominative nominative,
                          IPluralGenitive pluralGenitive)
        {
            _cardinalNumberSolverFactory = cardinalNumberSolverFactory ?? throw new System.ArgumentNullException(nameof(cardinalNumberSolverFactory));
            _genitive = genitive ?? throw new System.ArgumentNullException(nameof(genitive));
            _nominative = nominative ?? throw new System.ArgumentNullException(nameof(nominative));
            _pluralGenitive = pluralGenitive ?? throw new System.ArgumentNullException(nameof(pluralGenitive));
        }

        public string Provide(long number)
        {
            return CreateProvider().Provide(number);
        }

        private ICardinalNumberProvider CreateProvider()
        {
            return _cardinalNumberSolverFactory.Create(
                    basicNumbers: _genitive,
                    from_2_to_4_thousands: _pluralGenitive,
                    up_to_4_thousands: _pluralGenitive,
                    a_1_on_end: _nominative,
                    count_of_thousands: _genitive);
        }

        public static MasculineGenitive Create(INumberInWordsConfiguration configuration)
        {
            return new MasculineGenitive(
                        new CardinalNumberProviderFactory(new NumberSeparator(), configuration),
                        new SingularMasculineGenitive(),
                        new SingularMasculineNominative(),
                        new PluralGenitive());
        }
    }
}
