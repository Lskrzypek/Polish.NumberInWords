using Cardinals = Polish.NumbersInWords.PhraseAfterNumberProviders.Cardinal;
using Ordinals = Polish.NumbersInWords.PhraseAfterNumberProviders.Ordinal;
using System;

namespace Polish.NumbersInWords.PhraseAfterNumberProviders
{
    internal class PhraseAfterNumberProviderFactory : IPhraseAfterNumberProviderFactory
    {
        public IPhraseAfterNumberProvider Create(NumberProperties numberProperties)
        {
            if (numberProperties.CardinalOrdinal == CardinalOrdinal.Cardinal)
                return CreateCardinal(numberProperties);

            return CreateOrdinal(numberProperties);
        }

        private IPhraseAfterNumberProvider CreateCardinal(NumberProperties numberProperties)
        {
            switch(numberProperties.Case)
            {
                case Case.Nominative: return new Cardinals.MasculineNominative();
                case Case.Genitive: return new Cardinals.MasculineGenitive();
                case Case.Dative: return new Cardinals.MasculineDative();
                case Case.Accusative: return new Cardinals.MasculineAccusative();
                case Case.Instrumental: return new Cardinals.MasculineInstrumental();
                case Case.Locative: return new Cardinals.MasculineLocative();
                case Case.Vocative: return new Cardinals.MasculineVocative();
                default: throw new NotImplementedException();
            }
        }

        private IPhraseAfterNumberProvider CreateOrdinal(NumberProperties numberProperties)
        {
            switch (numberProperties.Case)
            {
                case Case.Nominative: return new Ordinals.Nominative();
                case Case.Genitive: return new Ordinals.Genitive();
                case Case.Dative: return new Ordinals.Dative();
                case Case.Accusative: return new Ordinals.Accusative();
                case Case.Instrumental: return new Ordinals.Instrumental();
                case Case.Locative: return new Ordinals.Locative();
                case Case.Vocative: return new Ordinals.Vocative();
                default: throw new NotImplementedException();
            }
        }
    }
}
