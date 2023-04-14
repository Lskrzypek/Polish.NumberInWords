namespace Polish.NumbersInWords
{
    /// <summary>
    /// Number properties like case, gender and cardinal/ordinal.
    /// </summary>
    public struct NumberProperties
    {
        public NumberProperties(CardinalOrdinal cardinalOrdinal, Case @case, Gender gender)
        {
            CardinalOrdinal = cardinalOrdinal;
            Case = @case;
            Gender = gender;
        }

        /// <summary>
        /// Cardinal or ordinal (PL: Liczebnik główny lub liczebnik porządkowy)
        /// </summary>
        public CardinalOrdinal CardinalOrdinal { get; set; }

        /// <summary>
        /// Case. For example: Nominative, Genitive... (PL: Przypadek. Na przykład mianownik, dopełniacz...)
        /// </summary>
        public Case Case { get; set; }

        /// <summary>
        /// Gender. For example: masculine, feminine... (PL: Rodzaj. Na przykład rodzaj męski, rodzaj żeński...)
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Create default properties - cardinal nominative masculine
        /// </summary>
        public static NumberProperties CreateDefault()
        {
            return new NumberProperties()
            {
                CardinalOrdinal = CardinalOrdinal.Cardinal,
                Case = Case.Nominative,
                Gender = Gender.Masculine
            };
        }
    }
}
