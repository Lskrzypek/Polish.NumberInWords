namespace Polish.NumbersInWords
{
    /// <summary>
    /// A phrase or a word with declensions. In most cases you should create a specific implementation of IPhrase. But sometimes you can use this class, when you want to set only few declensions.
    /// </summary>
    public class Phrase : IPhrase
    {
        /// <summary>
        /// Phrase in Nominative case (Mianownik - kto? co?)
        /// </summary>
        public string NominativeForm { get; set; }

        /// <summary>
        /// Phrase in Genitive case (Dopełniacz - kogo? czego?)
        /// </summary>
        public string GenitiveForm { get; set; }

        /// <summary>
        /// Phrase in Dative case (Celownik - komu? czemu?)
        /// </summary>
        public string DativeForm { get; set; }

        /// <summary>
        /// Phrase in Accusative case (Biernik - kogo? co?)
        /// </summary>
        public string AccusativeForm { get; set; }

        /// <summary>
        /// Phrase in Instrumental case (Narzędnik - z kim? z czym?)
        /// </summary>
        public string InstrumentalForm { get; set; }

        /// <summary>
        /// Phrase in Locactive case (Miejscownik - o kim? o czym?)
        /// </summary>
        public string LocativeForm { get; set; }

        /// <summary>
        /// Phrase in Vocative case (Wołacz)
        /// </summary>
        public string VocativeForm { get; set; }

        /// <summary>
        /// Phrase in Nominative case (Mianownik - kto? co?)
        /// </summary>
        public string PluralNominativeForm { get; set; }

        /// <summary>
        /// Phrase in Genitive case in plural (Dopełniacz - kogo? czego?)
        /// </summary>
        public string PluralGenitiveForm { get; set; }

        /// <summary>
        /// Phrase in Dative case in plural (Celownik - komu? czemu?)
        /// </summary>
        public string PluralDativeForm { get; set; }

        /// <summary>
        /// Phrase in Accusative in plural case (Biernik - kogo? co?)
        /// </summary>
        public string PluralAccusativeForm { get; set; }

        /// <summary>
        /// Phrase in Instrumental in plural case (Narzędnik - z kim? z czym?)
        /// </summary>
        public string PluralInstrumentalForm { get; set; }

        /// <summary>
        /// Phrase in Locactive case in plural (Miejscownik - o kim? o czym?)
        /// </summary>
        public string PluralLocativeForm { get; set; }

        /// <summary>
        /// Phrase in Vocative case in plural (Wołacz)
        /// </summary>
        public string PluralVocativeForm { get; set; }
    }
}
