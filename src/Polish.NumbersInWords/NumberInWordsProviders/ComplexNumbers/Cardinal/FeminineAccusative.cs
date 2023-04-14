﻿using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Plural;
using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Singular;
using Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal.Core;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal
{
    internal class FeminineAccusative : IFeminineAccusative
    {
        private readonly ICardinalNumberProviderFactory _cardinalNumberSolverFactory;
        private readonly ISingularFeminineAccusative _feminineAccusative;
        private readonly ISingularMasculineNominative _nominative;
        private readonly IPluralAccusative _pluralAccusative;
        private readonly IPluralGenitive _pluralGenitive;

        public FeminineAccusative(ICardinalNumberProviderFactory cardinalNumberSolverFactory,
                                   ISingularFeminineAccusative feminineAccusative,
                                   ISingularMasculineNominative nominative,
                                   IPluralAccusative pluralAccusative,
                                   IPluralGenitive pluralGenitive)
        {
            _cardinalNumberSolverFactory = cardinalNumberSolverFactory ?? throw new System.ArgumentNullException(nameof(cardinalNumberSolverFactory));
            _feminineAccusative = feminineAccusative ?? throw new System.ArgumentNullException(nameof(feminineAccusative));
            _nominative = nominative ?? throw new System.ArgumentNullException(nameof(nominative));
            _pluralAccusative = pluralAccusative ?? throw new System.ArgumentNullException(nameof(pluralAccusative));
            _pluralGenitive = pluralGenitive ?? throw new System.ArgumentNullException(nameof(pluralGenitive));
        }

        public string Provide(long number)
        {
            return CreateProvider().Provide(number);
        }

        private ICardinalNumberProvider CreateProvider()
        {
            return _cardinalNumberSolverFactory.Create(
                    basicNumbers: _feminineAccusative,
                    from_2_to_4_thousands: _pluralAccusative,
                    up_to_4_thousands: _pluralGenitive,
                    a_1_on_end: _nominative,
                    count_of_thousands: _nominative);
        }

        public static FeminineAccusative Create(INumberInWordsConfiguration configuration)
        {
            return new FeminineAccusative(
                        new CardinalNumberProviderFactory(new NumberSeparator(), configuration),
                        new SingularFeminineAccusative(),
                        new SingularMasculineNominative(),
                        new PluralAccusative(),
                        new PluralGenitive());
        }
    }
}
