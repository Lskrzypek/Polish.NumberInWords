namespace Polish.NumbersInWords.PhraseAfterNumberProviders.Cardinal
{
    internal class MasculineGenitive : IMasculineGenitive
    {
        public string Provide(long number, IPhrase phrase)
        {
            if (number == 1)
                return phrase.GenitiveForm;

            return phrase.PluralGenitiveForm;
        }
    }
}
