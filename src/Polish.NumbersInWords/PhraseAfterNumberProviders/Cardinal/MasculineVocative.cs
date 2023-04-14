namespace Polish.NumbersInWords.PhraseAfterNumberProviders.Cardinal
{
    internal class MasculineVocative : IMasculineVocative
    {
        public string Provide(long number, IPhrase phrase)
        {
            if (number == 0)
                return phrase.PluralGenitiveForm;

            if (number == 1)
                return phrase.VocativeForm;

            var lastDig = number % 10;
            var last2digs = number % 100;

            if (lastDig >= 2 && lastDig <= 4 && (last2digs > 20 || last2digs < 10))
                return phrase.PluralVocativeForm;

            return phrase.PluralGenitiveForm;
        }
    }
}
