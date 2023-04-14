using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Plural;
using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Singular;
using Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal.Core;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal
{
    internal class NeuterGenitive : INeuterGenitive
    {
        private readonly ICardinalNumberProviderFactory _cardinalNumberSolverFactory;
        private readonly ISingularNeuterGenitive _neuterGenitive;
        private readonly ISingularMasculineGenitive _masculineGenitive;
        private readonly ISingularMasculineNominative _nominative;
        private readonly IPluralGenitive _pluralGenitive;

        public NeuterGenitive(ICardinalNumberProviderFactory cardinalNumberSolverFactory,
                          ISingularNeuterGenitive neuterGenitive,
                          ISingularMasculineGenitive masculineGenitive,
                          ISingularMasculineNominative nominative,
                          IPluralGenitive pluralGenitive)
        {
            _cardinalNumberSolverFactory = cardinalNumberSolverFactory ?? throw new System.ArgumentNullException(nameof(cardinalNumberSolverFactory));
            _neuterGenitive = neuterGenitive ?? throw new System.ArgumentNullException(nameof(neuterGenitive));
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
                    basicNumbers: _neuterGenitive,
                    from_2_to_4_thousands: _pluralGenitive,
                    up_to_4_thousands: _pluralGenitive,
                    a_1_on_end: _nominative,
                    count_of_thousands: _masculineGenitive);
        }

        public static NeuterGenitive Create(INumberInWordsConfiguration configuration)
        {
            return new NeuterGenitive(
                        new CardinalNumberProviderFactory(new NumberSeparator(), configuration),
                        new SingularNeuterGenitive(),
                        new SingularMasculineGenitive(),
                        new SingularMasculineNominative(),
                        new PluralGenitive());
        }
    }
}
