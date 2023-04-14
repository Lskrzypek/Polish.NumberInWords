using Cardinals = Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Cardinal;
using Ordinals = Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal;
using System;

namespace Polish.NumbersInWords.NumberInWordsProviders
{
    internal class NumberInWordsProviderFactory : INumberInWordsProviderFactory
    {
        public INumberInWordsProvider Create(NumberProperties numberProperties, INumberInWordsConfiguration configuration)
        {
            if (numberProperties.CardinalOrdinal == CardinalOrdinal.Cardinal)
                return CreateCardinal(numberProperties, configuration);

            return CreateOrdinal(numberProperties, configuration);
        }

        private INumberInWordsProvider CreateCardinal(NumberProperties numberProperties, INumberInWordsConfiguration configuration)
        {
            switch(numberProperties.Case)
            {
                case Case.Nominative: return CreateCardinalNominative(numberProperties, configuration);
                case Case.Genitive: return CreateCardinalGenitive(numberProperties, configuration);
                case Case.Dative: return CreateCardinalDative(numberProperties, configuration);
                case Case.Accusative: return CreateCardinalAccusative(numberProperties, configuration);
                case Case.Instrumental: return CreateCardinalInstrumental(numberProperties, configuration);
                case Case.Locative: return CreateCardinalLocative(numberProperties, configuration);
                case Case.Vocative: return CreateCardinalVocative(numberProperties, configuration);
                default: throw new NotImplementedException();
            }
        }

        private INumberInWordsProvider CreateOrdinal(NumberProperties numberProperties, INumberInWordsConfiguration configuration)
        {
            switch (numberProperties.Case)
            {
                case Case.Nominative: return CreateOrdinalNominative(numberProperties, configuration);
                case Case.Genitive: return CreateOrdinalGenitive(numberProperties, configuration);
                case Case.Dative: return CreateOrdinalDative(numberProperties, configuration);
                case Case.Accusative: return CreateOrdinalAccusative(numberProperties, configuration);
                case Case.Instrumental: return CreateOrdinalInstrumental(numberProperties, configuration);
                case Case.Locative: return CreateOrdinalLocative(numberProperties, configuration);
                case Case.Vocative: return CreateOrdinalVocative(numberProperties, configuration);
                default: throw new NotImplementedException();
            }
        }

        private INumberInWordsProvider CreateCardinalNominative(NumberProperties numberProperties, INumberInWordsConfiguration configuration)
        {
            switch(numberProperties.Gender)
            {
                case Gender.Masculine: return Cardinals.MasculineNominative.Create(configuration);
                case Gender.Feminine: return Cardinals.FeminineNominative.Create(configuration);
                case Gender.Neuter: return Cardinals.NeuterNominative.Create(configuration);
                default: throw new NotImplementedException();
            }
        }

        private INumberInWordsProvider CreateCardinalGenitive(NumberProperties numberProperties, INumberInWordsConfiguration configuration)
        {
            switch (numberProperties.Gender)
            {
                case Gender.Masculine: return Cardinals.MasculineGenitive.Create(configuration);
                case Gender.Feminine: return Cardinals.FeminineGenitive.Create(configuration);
                case Gender.Neuter: return Cardinals.NeuterGenitive.Create(configuration);
                default: throw new NotImplementedException();
            }
        }

        private INumberInWordsProvider CreateCardinalDative(NumberProperties numberProperties, INumberInWordsConfiguration configuration)
        {
            switch (numberProperties.Gender)
            {
                case Gender.Masculine: return Cardinals.MasculineDative.Create(configuration);
                case Gender.Feminine: return Cardinals.FeminineDative.Create(configuration);
                case Gender.Neuter: return Cardinals.NeuterDative.Create(configuration);
                default: throw new NotImplementedException();
            }
        }

        private INumberInWordsProvider CreateCardinalAccusative(NumberProperties numberProperties, INumberInWordsConfiguration configuration)
        {
            switch (numberProperties.Gender)
            {
                case Gender.Masculine: return Cardinals.MasculineAccusative.Create(configuration);
                case Gender.Feminine: return Cardinals.FeminineAccusative.Create(configuration);
                case Gender.Neuter: return Cardinals.NeuterAccusative.Create(configuration);
                default: throw new NotImplementedException();
            }
        }

        private INumberInWordsProvider CreateCardinalInstrumental(NumberProperties numberProperties, INumberInWordsConfiguration configuration)
        {
            switch (numberProperties.Gender)
            {
                case Gender.Masculine: return Cardinals.MasculineInstrumental.Create(configuration);
                case Gender.Feminine: return Cardinals.FeminineInstrumental.Create(configuration);
                case Gender.Neuter: return Cardinals.NeuterInstrumental.Create(configuration);
                default: throw new NotImplementedException();
            }
        }

        private INumberInWordsProvider CreateCardinalLocative(NumberProperties numberProperties, INumberInWordsConfiguration configuration)
        {
            switch (numberProperties.Gender)
            {
                case Gender.Masculine: return Cardinals.MasculineLocative.Create(configuration);
                case Gender.Feminine: return Cardinals.FeminineLocative.Create(configuration);
                case Gender.Neuter: return Cardinals.NeuterLocative.Create(configuration);
                default: throw new NotImplementedException();
            }
        }

        private INumberInWordsProvider CreateCardinalVocative(NumberProperties numberProperties, INumberInWordsConfiguration configuration)
        {
            switch (numberProperties.Gender)
            {
                case Gender.Masculine: return Cardinals.MasculineVocative.Create(configuration);
                case Gender.Feminine: return Cardinals.FeminineVocative.Create(configuration);
                case Gender.Neuter: return Cardinals.NeuterVocative.Create(configuration);
                default: throw new NotImplementedException();
            }
        }

        private INumberInWordsProvider CreateOrdinalNominative(NumberProperties numberProperties, INumberInWordsConfiguration configuration)
        {
            switch (numberProperties.Gender)
            {
                case Gender.Masculine: return Ordinals.MasculineNominative.Create(configuration);
                case Gender.Feminine: return Ordinals.FeminineNominative.Create(configuration);
                case Gender.Neuter: return Ordinals.NeuterNominative.Create(configuration);
                default: throw new NotImplementedException();
            }
        }

        private INumberInWordsProvider CreateOrdinalGenitive(NumberProperties numberProperties, INumberInWordsConfiguration configuration)
        {
            switch (numberProperties.Gender)
            {
                case Gender.Masculine: return Ordinals.MasculineGenitive.Create(configuration);
                case Gender.Feminine: return Ordinals.FeminineGenitive.Create(configuration);
                case Gender.Neuter: return Ordinals.NeuterGenitive.Create(configuration);
                default: throw new NotImplementedException();
            }
        }

        private INumberInWordsProvider CreateOrdinalDative(NumberProperties numberProperties, INumberInWordsConfiguration configuration)
        {
            switch (numberProperties.Gender)
            {
                case Gender.Masculine: return Ordinals.MasculineDative.Create(configuration);
                case Gender.Feminine: return Ordinals.FeminineDative.Create(configuration);
                case Gender.Neuter: return Ordinals.NeuterDative.Create(configuration);
                default: throw new NotImplementedException();
            }
        }

        private INumberInWordsProvider CreateOrdinalAccusative(NumberProperties numberProperties, INumberInWordsConfiguration configuration)
        {
            switch (numberProperties.Gender)
            {
                case Gender.Masculine: return Ordinals.MasculineAccusative.Create(configuration);
                case Gender.Feminine: return Ordinals.FeminineAccusative.Create(configuration);
                case Gender.Neuter: return Ordinals.NeuterAccusative.Create(configuration);
                default: throw new NotImplementedException();
            }
        }

        private INumberInWordsProvider CreateOrdinalInstrumental(NumberProperties numberProperties, INumberInWordsConfiguration configuration)
        {
            switch (numberProperties.Gender)
            {
                case Gender.Masculine: return Ordinals.MasculineInstrumental.Create(configuration);
                case Gender.Feminine: return Ordinals.FeminineInstrumental.Create(configuration);
                case Gender.Neuter: return Ordinals.NeuterInstrumental.Create(configuration);
                default: throw new NotImplementedException();
            }
        }

        private INumberInWordsProvider CreateOrdinalLocative(NumberProperties numberProperties, INumberInWordsConfiguration configuration)
        {
            switch (numberProperties.Gender)
            {
                case Gender.Masculine: return Ordinals.MasculineLocative.Create(configuration);
                case Gender.Feminine: return Ordinals.FeminineLocative.Create(configuration);
                case Gender.Neuter: return Ordinals.NeuterLocative.Create(configuration);
                default: throw new NotImplementedException();
            }
        }

        private INumberInWordsProvider CreateOrdinalVocative(NumberProperties numberProperties, INumberInWordsConfiguration configuration)
        {
            switch (numberProperties.Gender)
            {
                case Gender.Masculine: return Ordinals.MasculineVocative.Create(configuration);
                case Gender.Feminine: return Ordinals.FeminineVocative.Create(configuration);
                case Gender.Neuter: return Ordinals.NeuterVocative.Create(configuration);
                default: throw new NotImplementedException();
            }
        }
    }
}
