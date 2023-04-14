namespace Polish.NumbersInWords.Tests
{
    public class BasicTests
    {
        [Fact]
        public void ToWords_default()
        {
            long number = 1234;

            string resultWords = number.ToPolishWords();

            Assert.Equal("tysi¹c dwieœcie trzydzieœci cztery", resultWords);
        }

        [Fact]
        public void ToWords_other_case()
        {
            long number = 13;

            string resultWords = number.ToPolishWords()
                .Case(Case.Genitive);

            Assert.Equal("trzynastu", resultWords);
        }

        [Fact]
        public void ToWords_ordinal()
        {
            long number = 25;

            string resultWords = number.ToPolishWords()
                .Ordinal();

            Assert.Equal("dwudziesty pi¹ty", resultWords);
        }

        [Theory]
        [InlineData(1, "jeden du¿y stó³")]
        [InlineData(2, "dwa du¿e sto³y")]
        [InlineData(8, "osiem du¿ych sto³ów")]
        public void ToWords_default_with_phrase_after_number(long number, string expected)
        {
            var phrase = new Phrase()
            {
                NominativeForm = "du¿y stó³",
                PluralNominativeForm = "du¿e sto³y",
                PluralGenitiveForm = "du¿ych sto³ów"
            };

            var result = number.ToPolishWords()
                .Write(x => string.Format("{0} {1}", x.Words, x.GetPhraseAfterNumber(phrase)));

            Assert.Equal(expected, result);
        }

    }
}