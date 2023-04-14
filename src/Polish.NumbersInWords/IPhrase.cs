namespace Polish.NumbersInWords
{
    /// <summary>
    /// A phrase or a word with declensions.
    /// </summary>
    public interface IPhrase
    {
        /// <summary>
        /// Phrase in Nominative case (Mianownik - kto? co?)
        /// </summary>
        string NominativeForm { get; }

        /// <summary>
        /// Phrase in Genitive case (Dopełniacz - kogo? czego?)
        /// </summary>
        string GenitiveForm { get; }

        /// <summary>
        /// Phrase in Dative case (Celownik - komu? czemu?)
        /// </summary>
        string DativeForm { get; }

        /// <summary>
        /// Phrase in Accusative case (Biernik - kogo? co?)
        /// </summary>
        string AccusativeForm { get; }

        /// <summary>
        /// Phrase in Instrumental case (Narzędnik - z kim? z czym?)
        /// </summary>
        string InstrumentalForm { get; }

        /// <summary>
        /// Phrase in Locactive case (Miejscownik - o kim? o czym?)
        /// </summary>
        string LocativeForm { get; }

        /// <summary>
        /// Phrase in Vocative case (Wołacz)
        /// </summary>
        string VocativeForm { get; }

        /// <summary>
        /// Phrase in Nominative case (Mianownik - kto? co?)
        /// </summary>
        string PluralNominativeForm { get; }

        /// <summary>
        /// Phrase in Genitive case in plural (Dopełniacz - kogo? czego?)
        /// </summary>
        string PluralGenitiveForm { get; }

        /// <summary>
        /// Phrase in Dative case in plural (Celownik - komu? czemu?)
        /// </summary>
        string PluralDativeForm { get; }

        /// <summary>
        /// Phrase in Accusative in plural case (Biernik - kogo? co?)
        /// </summary>
        string PluralAccusativeForm { get; }

        /// <summary>
        /// Phrase in Instrumental in plural case (Narzędnik - z kim? z czym?)
        /// </summary>
        string PluralInstrumentalForm { get; }

        /// <summary>
        /// Phrase in Locactive case in plural (Miejscownik - o kim? o czym?)
        /// </summary>
        string PluralLocativeForm { get; }

        /// <summary>
        /// Phrase in Vocative case in plural (Wołacz)
        /// </summary>
        string PluralVocativeForm { get; }
    }
}
