using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Plural;
using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Singular;
using Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal.Core;
using System.Threading;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal
{
    internal class MasculineVocative : IMasculineVocative
    {
        private readonly ICardinalNumberProviderFactory _cardinalNumberSolverFactory;
        private readonly ISingularMasculineVocative _vocative;
        private readonly IPluralVocative _pluralVocative;
        private readonly IPluralGenitive _pluralGenitive;

        public MasculineVocative(ICardinalNumberProviderFactory cardinalNumberSolverFactory,
                                 ISingularMasculineVocative vocative,
                                 IPluralVocative pluralVocative,
                                 IPluralGenitive pluralGenitive)
        {
            _cardinalNumberSolverFactory = cardinalNumberSolverFactory ?? throw new System.ArgumentNullException(nameof(cardinalNumberSolverFactory));
            _vocative = vocative ?? throw new System.ArgumentNullException(nameof(vocative));
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
                    basicNumbers: _vocative,
                    from_2_to_4_thousands: _pluralVocative,
                    up_to_4_thousands: _pluralGenitive,
                    a_1_on_end: _vocative,
                    count_of_thousands: _vocative);
        }

        public static MasculineVocative Create(INumberInWordsConfiguration configuration)
        {
            return new MasculineVocative(
                        new CardinalNumberProviderFactory(new NumberSeparator(), configuration),
                        new SingularMasculineVocative(),
                        new PluralVocative(),
                        new PluralGenitive());
        }
    }
}
