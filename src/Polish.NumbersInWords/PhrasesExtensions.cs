namespace Polish.NumbersInWords
{
    public static class PhrasesExtensions
    {
        /// <summary>
        /// Returns phrase in case and plurality
        /// </summary>
        public static string GetWord(this IPhrase phrase, Case @case = Case.Nominative, bool isPlural = false)
        {
            if (isPlural)
                return GetWordPlural(phrase, @case);

            return GetWordSingular(phrase, @case);
        }

        private static string GetWordSingular(IPhrase phrase, Case @case)
        {
            switch(@case)
            {
                case Case.Nominative: return phrase.NominativeForm;
                case Case.Genitive: return phrase.GenitiveForm;
                case Case.Dative: return phrase.DativeForm;
                case Case.Accusative: return phrase.AccusativeForm;
                case Case.Instrumental: return phrase.InstrumentalForm;
                case Case.Locative: return phrase.LocativeForm;
                case Case.Vocative: return phrase.VocativeForm;
                default: throw new System.Exception($"Unknown case: {@case}");
            }
        }

        private static string GetWordPlural(IPhrase phrase, Case @case)
        {
            switch (@case)
            {
                case Case.Nominative: return phrase.PluralNominativeForm;
                case Case.Genitive: return phrase.PluralGenitiveForm;
                case Case.Dative: return phrase.PluralDativeForm;
                case Case.Accusative: return phrase.PluralAccusativeForm;
                case Case.Instrumental: return phrase.PluralInstrumentalForm;
                case Case.Locative: return phrase.PluralLocativeForm;
                case Case.Vocative: return phrase.PluralVocativeForm;
                default: throw new System.Exception($"Unknown case: {@case}");
            }
        }
    }
}
