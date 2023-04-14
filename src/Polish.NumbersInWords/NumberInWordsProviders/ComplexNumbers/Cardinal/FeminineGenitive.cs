using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Plural;
using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Singular;
using Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal.Core;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal
{
    internal class FeminineGenitive : IFeminineGenitive
    {
        private readonly ICardinalNumberProviderFactory _cardinalNumberSolverFactory;
        private readonly ISingularFeminineGenitive _feminineGenitive;
        private readonly ISingularMasculineGenitive _masculineGenitive;
        private readonly ISingularMasculineNominative _nominative;
        private readonly IPluralGenitive _pluralGenitive;

        public FeminineGenitive(ICardinalNumberProviderFactory cardinalNumberSolverFactory,
                          ISingularFeminineGenitive feminineGenitive,
                          ISingularMasculineGenitive masculineGenitive,
                          ISingularMasculineNominative nominative,
                          IPluralGenitive pluralGenitive)
        {
            _cardinalNumberSolverFactory = cardinalNumberSolverFactory ?? throw new System.ArgumentNullException(nameof(cardinalNumberSolverFactory));
            _feminineGenitive = feminineGenitive ?? throw new System.ArgumentNullException(nameof(feminineGenitive));
            _masculineGenitive = masculineGenitive ?? throw new System.ArgumentNullException(nameof(masculineGenitive));
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
                    basicNumbers: _feminineGenitive,
                    from_2_to_4_thousands: _pluralGenitive,
                    up_to_4_thousands: _pluralGenitive,
                    a_1_on_end: _nominative,
                    count_of_thousands: _masculineGenitive);
        }

        public static FeminineGenitive Create(INumberInWordsConfiguration configuration)
        {
            return new FeminineGenitive(
                        new CardinalNumberProviderFactory(new NumberSeparator(), configuration),
                        new SingularFeminineGenitive(),
                        new SingularMasculineGenitive(),
                        new SingularMasculineNominative(),
                        new PluralGenitive());
        }
    }
}
