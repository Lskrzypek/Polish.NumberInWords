using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Plural;
using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Singular;
using Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal.Core;
using System.Threading;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal
{
    internal class NeuterVocative : INeuterVocative
    {
        private readonly ICardinalNumberProviderFactory _cardinalNumberSolverFactory;
        private readonly ISingularNeuterVocative _neuterVocative;
        private readonly ISingularMasculineVocative _masculineVocative;
        private readonly IPluralVocative _pluralVocative;
        private readonly IPluralGenitive _pluralGenitive;

        public NeuterVocative(ICardinalNumberProviderFactory cardinalNumberSolverFactory,
                                 ISingularNeuterVocative neuterVocative,
                                 ISingularMasculineVocative masculineVocative,
                                 IPluralVocative pluralVocative,
                                 IPluralGenitive pluralGenitive)
        {
            _cardinalNumberSolverFactory = cardinalNumberSolverFactory ?? throw new System.ArgumentNullException(nameof(cardinalNumberSolverFactory));
            _neuterVocative = neuterVocative ?? throw new System.ArgumentNullException(nameof(neuterVocative));
            _masculineVocative = masculineVocative ?? throw new System.ArgumentNullException(nameof(masculineVocative));
            _pluralVocative = pluralVocative ?? throw new System.ArgumentNullException(nameof(pluralVocative));
            _pluralGenitive = pluralGenitive ?? throw new System.ArgumentNullException(nameof(pluralGenitive));
        }

        public string Provide(long number)
        {
            return CreateProvider().Provide(number);
        }

        private ICardinalNumberProvider CreateProvider()
        {
            return _cardinalNumberSolverFactory.Create(
                    basicNumbers: _neuterVocative,
                    from_2_to_4_thousands: _pluralVocative,
                    up_to_4_thousands: _pluralGenitive,
                    a_1_on_end: _masculineVocative,
                    count_of_thousands: _masculineVocative);
        }

        public static NeuterVocative Create(INumberInWordsConfiguration configuration)
        {
            return new NeuterVocative(
                        new CardinalNumberProviderFactory(new NumberSeparator(), configuration),
                        new SingularNeuterVocative(),
                        new SingularMasculineVocative(),
                        new PluralVocative(),
                        new PluralGenitive());
        }
    }
}
