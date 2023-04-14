using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Plural;
using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Singular;
using Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal.Core;
using System.Threading;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal
{
    internal class FeminineVocative : IFeminineVocative
    {
        private readonly ICardinalNumberProviderFactory _cardinalNumberSolverFactory;
        private readonly ISingularFeminineVocative _feminineVocative;
        private readonly ISingularMasculineVocative _masculineVocative;
        private readonly IPluralVocative _pluralVocative;
        private readonly IPluralGenitive _pluralGenitive;

        public FeminineVocative(ICardinalNumberProviderFactory cardinalNumberSolverFactory,
                                 ISingularFeminineVocative feminineVocative,
                                 ISingularMasculineVocative masculineVocative,
                                 IPluralVocative pluralVocative,
                                 IPluralGenitive pluralGenitive)
        {
            _cardinalNumberSolverFactory = cardinalNumberSolverFactory ?? throw new System.ArgumentNullException(nameof(cardinalNumberSolverFactory));
            _feminineVocative = feminineVocative ?? throw new System.ArgumentNullException(nameof(feminineVocative));
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
                    basicNumbers: _feminineVocative,
                    from_2_to_4_thousands: _pluralVocative,
                    up_to_4_thousands: _pluralGenitive,
                    a_1_on_end: _masculineVocative,
                    count_of_thousands: _masculineVocative);
        }

        public static FeminineVocative Create(INumberInWordsConfiguration configuration)
        {
            return new FeminineVocative(
                        new CardinalNumberProviderFactory(new NumberSeparator(), configuration),
                        new SingularFeminineVocative(),
                        new SingularMasculineVocative(),
                        new PluralVocative(),
                        new PluralGenitive());
        }
    }
}
