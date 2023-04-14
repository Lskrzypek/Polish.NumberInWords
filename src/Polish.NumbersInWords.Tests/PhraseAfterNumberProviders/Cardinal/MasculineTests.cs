namespace Polish.NumbersInWords.Tests.PhraseAfterNumberProviders.Cardinal
{
    public class MasculineTests
    {
        #region Masculine Nominative

        [Theory]
        [InlineData(0, "czajników")]
        [InlineData(1, "czajnik")]
        [InlineData(2, "czajniki")]
        [InlineData(3, "czajniki")]
        [InlineData(4, "czajniki")]
        [InlineData(5, "czajników")]
        [InlineData(11, "czajników")]
        [InlineData(12, "czajników")]
        [InlineData(15, "czajników")]
        [InlineData(21, "czajników")]
        [InlineData(22, "czajniki")]
        [InlineData(123, "czajniki")]
        [InlineData(125, "czajników")]
        [InlineData(1000, "czajników")]
        [InlineData(1001, "czajników")]
        [InlineData(1002, "czajniki")]
        [InlineData(1005, "czajników")]
        [InlineData(1124, "czajniki")]
        [InlineData(10000, "czajników")]
        [InlineData(10001, "czajników")]
        [InlineData(10002, "czajniki")]
        [InlineData(11125, "czajników")]
        public void Match_word_teapot(long number, string expectedDeclension)
        {
            var returnValue = number.ToPolishWords()
                .NumberElements
                .GetPhraseAfterNumber(teapot);

            Assert.Equal(expectedDeclension, returnValue);
        }

        #endregion

        #region Masculine Genitive

        [Theory]
        [InlineData(0, "czajników")]
        [InlineData(1, "czajnika")]
        [InlineData(2, "czajników")]
        [InlineData(3, "czajników")]
        [InlineData(4, "czajników")]
        [InlineData(5, "czajników")]
        [InlineData(11, "czajników")]
        [InlineData(12, "czajników")]
        [InlineData(15, "czajników")]
        [InlineData(21, "czajników")]
        [InlineData(22, "czajników")]
        [InlineData(123, "czajników")]
        [InlineData(1000, "czajników")]
        [InlineData(1002, "czajników")]
        [InlineData(1124, "czajników")]
        [InlineData(10000, "czajników")]
        [InlineData(10001, "czajników")]
        [InlineData(10002, "czajników")]
        [InlineData(11125, "czajników")]
        public void Match_word_teapot_genitive(long number, string expectedDeclension)
        {
            var returnValue = number.ToPolishWords()
                .Case(Case.Genitive)
                .NumberElements
                .GetPhraseAfterNumber(teapot);

            Assert.Equal(expectedDeclension, returnValue);
        }

        #endregion

        #region Masculine Dative

        [Theory]
        [InlineData(0, "czajnikom")]
        [InlineData(1, "czajnikowi")]
        [InlineData(2, "czajnikom")]
        [InlineData(3, "czajnikom")]
        [InlineData(4, "czajnikom")]
        [InlineData(5, "czajnikom")]
        [InlineData(11, "czajnikom")]
        [InlineData(12, "czajnikom")]
        [InlineData(15, "czajnikom")]
        [InlineData(21, "czajnikom")]
        [InlineData(22, "czajnikom")]
        [InlineData(123, "czajnikom")]
        [InlineData(1000, "czajników")]
        [InlineData(1002, "czajnikom")]
        [InlineData(1124, "czajnikom")]
        [InlineData(10000, "czajników")]
        [InlineData(10001, "czajników")]
        [InlineData(10002, "czajnikom")]
        [InlineData(11125, "czajnikom")]
        public void Match_word_teapot_dative(long number, string expectedDeclension)
        {
            var returnValue = number.ToPolishWords()
                .Case(Case.Dative)
                .NumberElements
                .GetPhraseAfterNumber(teapot);

            Assert.Equal(expectedDeclension, returnValue);
        }

        #endregion

        #region Masculine Accusative

        [Theory]
        [InlineData(0, "czajników")]
        [InlineData(1, "czajnik")]
        [InlineData(2, "czajniki")]
        [InlineData(3, "czajniki")]
        [InlineData(4, "czajniki")]
        [InlineData(5, "czajników")]
        [InlineData(11, "czajników")]
        [InlineData(12, "czajników")]
        [InlineData(15, "czajników")]
        [InlineData(21, "czajników")]
        [InlineData(22, "czajniki")]
        [InlineData(123, "czajniki")]
        [InlineData(1000, "czajników")]
        [InlineData(1002, "czajniki")]
        [InlineData(1124, "czajniki")]
        [InlineData(10000, "czajników")]
        [InlineData(10001, "czajników")]
        [InlineData(10002, "czajniki")]
        [InlineData(11125, "czajników")]
        public void Match_word_teapot_accusative(long number, string expectedDeclension)
        {
            var returnValue = number.ToPolishWords()
                .Case(Case.Accusative)
                .NumberElements
                .GetPhraseAfterNumber(teapot);

            Assert.Equal(expectedDeclension, returnValue);
        }

        #endregion

        #region Masculine Instrumental

        [Theory]
        [InlineData(0, "czajników")]
        [InlineData(1, "czajnikiem")]
        [InlineData(2, "czajnikami")]
        [InlineData(3, "czajnikami")]
        [InlineData(4, "czajnikami")]
        [InlineData(5, "czajnikami")]
        [InlineData(11, "czajnikami")]
        [InlineData(12, "czajnikami")]
        [InlineData(15, "czajnikami")]
        [InlineData(21, "czajnikami")]
        [InlineData(22, "czajnikami")]
        [InlineData(123, "czajnikami")]
        [InlineData(1000, "czajników")]
        [InlineData(1002, "czajnikami")]
        [InlineData(1124, "czajnikami")]
        [InlineData(10000, "czajników")]
        [InlineData(10001, "czajników")]
        [InlineData(10002, "czajnikami")]
        [InlineData(11125, "czajnikami")]
        public void Match_word_teapot_instrumental(long number, string expectedDeclension)
        {
            var returnValue = number.ToPolishWords()
                .Case(Case.Instrumental)
                .NumberElements
                .GetPhraseAfterNumber(teapot);

            Assert.Equal(expectedDeclension, returnValue);
        }

        #endregion

        #region Masculine Locative

        [Theory]
        [InlineData(0, "czajników")]
        [InlineData(1, "czajniku")]
        [InlineData(2, "czajnikach")]
        [InlineData(3, "czajnikach")]
        [InlineData(4, "czajnikach")]
        [InlineData(5, "czajnikach")]
        [InlineData(11, "czajnikach")]
        [InlineData(12, "czajnikach")]
        [InlineData(15, "czajnikach")]
        [InlineData(21, "czajnikach")]
        [InlineData(22, "czajnikach")]
        [InlineData(123, "czajnikach")]
        [InlineData(1000, "czajników")]
        [InlineData(1002, "czajnikach")]
        [InlineData(1124, "czajnikach")]
        [InlineData(10000, "czajników")]
        [InlineData(10001, "czajników")]
        [InlineData(10002, "czajnikach")]
        [InlineData(11125, "czajnikach")]
        public void Match_word_teapot_locative(long number, string expectedDeclension)
        {
            var returnValue = number.ToPolishWords()
                .Case(Case.Locative)
                .NumberElements
                .GetPhraseAfterNumber(teapot);

            Assert.Equal(expectedDeclension, returnValue);
        }

        #endregion

        #region Masculine Voacative

        [Theory]
        [InlineData(0, "czajników")]
        [InlineData(1, "czajnik")]
        [InlineData(2, "czajniki")]
        [InlineData(3, "czajniki")]
        [InlineData(4, "czajniki")]
        [InlineData(5, "czajników")]
        [InlineData(11, "czajników")]
        [InlineData(12, "czajników")]
        [InlineData(15, "czajników")]
        [InlineData(21, "czajników")]
        [InlineData(22, "czajniki")]
        [InlineData(123, "czajniki")]
        [InlineData(1000, "czajników")]
        [InlineData(1002, "czajniki")]
        [InlineData(1124, "czajniki")]
        [InlineData(10000, "czajników")]
        [InlineData(10001, "czajników")]
        [InlineData(10002, "czajniki")]
        [InlineData(11125, "czajników")]
        public void Match_word_teapot_vocative(long number, string expectedDeclension)
        {
            var returnValue = number.ToPolishWords()
                .Case(Case.Vocative)
                .NumberElements
                .GetPhraseAfterNumber(teapot);

            Assert.Equal(expectedDeclension, returnValue);
        }

        #endregion

        #region Data
        private static Phrase teapot = new Phrase()
        {
            NominativeForm = "czajnik",
            GenitiveForm = "czajnika",
            DativeForm = "czajnikowi",
            AccusativeForm = "czajnik",
            InstrumentalForm = "czajnikiem",
            LocativeForm = "czajniku",
            VocativeForm = "czajnik",
            PluralNominativeForm = "czajniki",
            PluralGenitiveForm = "czajników",
            PluralDativeForm = "czajnikom",
            PluralAccusativeForm = "czajniki",
            PluralInstrumentalForm = "czajnikami",
            PluralLocativeForm = "czajnikach",
            PluralVocativeForm = "czajniki"
        };
        #endregion
    }
}
