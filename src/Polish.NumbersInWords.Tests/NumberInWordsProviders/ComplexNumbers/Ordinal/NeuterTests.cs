﻿namespace Polish.NumbersInWords.Tests.NumberInWordsProviders.ComplexNumbers.Ordinal
{
    public class NeuterTests
    {
        #region Neuter Nominative
        [Theory]
        [InlineData(1, "pierwsze")]
        [InlineData(2, "drugie")]
        [InlineData(3, "trzecie")]
        [InlineData(4, "czwarte")]
        [InlineData(5, "piąte")]
        [InlineData(6, "szóste")]
        [InlineData(7, "siódme")]
        [InlineData(8, "ósme")]
        [InlineData(9, "dziewiąte")]
        [InlineData(10, "dziesiąte")]
        [InlineData(11, "jedenaste")]
        [InlineData(12, "dwunaste")]
        [InlineData(13, "trzynaste")]
        [InlineData(14, "czternaste")]
        [InlineData(15, "piętnaste")]
        [InlineData(16, "szesnaste")]
        [InlineData(17, "siedemnaste")]
        [InlineData(18, "osiemnaste")]
        [InlineData(19, "dziewiętnaste")]
        [InlineData(20, "dwudzieste")]
        [InlineData(30, "trzydzieste")]
        [InlineData(40, "czterdzieste")]
        [InlineData(50, "pięćdziesiąte")]
        [InlineData(60, "sześćdziesiąte")]
        [InlineData(70, "siedemdziesiąte")]
        [InlineData(80, "osiemdziesiąte")]
        [InlineData(90, "dziewięćdziesiąte")]
        [InlineData(21, "dwudzieste pierwsze")]
        [InlineData(32, "trzydzieste drugie")]
        [InlineData(43, "czterdzieste trzecie")]
        [InlineData(100, "setne")]
        [InlineData(200, "dwusetne")]
        [InlineData(300, "trzechsetne")]
        [InlineData(400, "czterechsetne")]
        [InlineData(500, "pięćsetne")]
        [InlineData(600, "sześćsetne")]
        [InlineData(700, "siedemsetne")]
        [InlineData(800, "osiemsetne")]
        [InlineData(900, "dziewięćsetne")]
        [InlineData(101, "sto pierwsze")]
        [InlineData(202, "dwieście drugie")]
        [InlineData(310, "trzysta dziesiąte")]
        [InlineData(412, "czterysta dwunaste")]
        [InlineData(556, "pięćset pięćdziesiąte szóste")]
        [InlineData(1000, "tysięczne")]
        [InlineData(1000000, "milionowe")]
        [InlineData(1000000000, "miliardowe")]
        [InlineData(1000000000000, "bilionowe")]
        [InlineData(2000, "dwutysięczne")]
        [InlineData(5000, "pięciotysięczne")]
        [InlineData(101000, "stujednotysięczne")]
        [InlineData(206000, "dwóchsetsześciotysięczne")]
        [InlineData(1234567890, "miliard dwieście trzydzieści cztery miliony pięćset sześćdziesiąt siedem tysięcy osiemset dziewięćdziesiąte")]
        [InlineData(1001001001, "miliard milion tysiąc pierwsze")]
        [InlineData(413254, "czterysta trzynaście tysięcy dwieście pięćdziesiąte czwarte")]
        [InlineData(1012, "tysiąc dwunaste")]
        [InlineData(2137, "dwa tysiące sto trzydzieste siódme")]
        [InlineData(2022202000, "dwa miliardy dwadzieścia dwa miliony dwóchsetdwutysięczne")]
        [InlineData(12002020100, "dwanaście miliardów dwa miliony dwadzieścia tysięcy setne")]
        public void ToWords_Nominative(long number, string expectedWords)
        {
            string resultWords = number.ToPolishWords()
                .Ordinal()
                .Gender(Gender.Neuter)
                .Case(Case.Nominative);

            Assert.Equal(expectedWords, resultWords);
        }

        #endregion

        #region Neuter Genitive
        [Theory]
        [InlineData(1, "pierwszego")]
        [InlineData(2, "drugiego")]
        [InlineData(3, "trzeciego")]
        [InlineData(4, "czwartego")]
        [InlineData(5, "piątego")]
        [InlineData(6, "szóstego")]
        [InlineData(7, "siódmego")]
        [InlineData(8, "ósmego")]
        [InlineData(9, "dziewiątego")]
        [InlineData(10, "dziesiątego")]
        [InlineData(11, "jedenastego")]
        [InlineData(12, "dwunastego")]
        [InlineData(13, "trzynastego")]
        [InlineData(14, "czternastego")]
        [InlineData(15, "piętnastego")]
        [InlineData(16, "szesnastego")]
        [InlineData(17, "siedemnastego")]
        [InlineData(18, "osiemnastego")]
        [InlineData(19, "dziewiętnastego")]
        [InlineData(20, "dwudziestego")]
        [InlineData(30, "trzydziestego")]
        [InlineData(40, "czterdziestego")]
        [InlineData(50, "pięćdziesiątego")]
        [InlineData(60, "sześćdziesiątego")]
        [InlineData(70, "siedemdziesiątego")]
        [InlineData(80, "osiemdziesiątego")]
        [InlineData(90, "dziewięćdziesiątego")]
        [InlineData(21, "dwudziestego pierwszego")]
        [InlineData(32, "trzydziestego drugiego")]
        [InlineData(43, "czterdziestego trzeciego")]
        [InlineData(100, "setnego")]
        [InlineData(200, "dwusetnego")]
        [InlineData(300, "trzechsetnego")]
        [InlineData(400, "czterechsetnego")]
        [InlineData(500, "pięćsetnego")]
        [InlineData(600, "sześćsetnego")]
        [InlineData(700, "siedemsetnego")]
        [InlineData(800, "osiemsetnego")]
        [InlineData(900, "dziewięćsetnego")]
        [InlineData(101, "sto pierwszego")]
        [InlineData(202, "dwieście drugiego")]
        [InlineData(310, "trzysta dziesiątego")]
        [InlineData(412, "czterysta dwunastego")]
        [InlineData(556, "pięćset pięćdziesiątego szóstego")]
        [InlineData(1000, "tysięcznego")]
        [InlineData(1000000, "milionowego")]
        [InlineData(1000000000, "miliardowego")]
        [InlineData(1000000000000, "bilionowego")]
        [InlineData(2000, "dwutysięcznego")]
        [InlineData(5000, "pięciotysięcznego")]
        [InlineData(101000, "stujednotysięcznego")]
        [InlineData(206000, "dwóchsetsześciotysięcznego")]
        [InlineData(1234567890, "miliard dwieście trzydzieści cztery miliony pięćset sześćdziesiąt siedem tysięcy osiemset dziewięćdziesiątego")]
        [InlineData(1001001001, "miliard milion tysiąc pierwszego")]
        [InlineData(413254, "czterysta trzynaście tysięcy dwieście pięćdziesiątego czwartego")]
        public void ToWords_Genitive(long number, string expectedWords)
        {
            string resultWords = number.ToPolishWords()
                .Ordinal()
                .Gender(Gender.Neuter)
                .Case(Case.Genitive);

            Assert.Equal(expectedWords, resultWords);
        }

        #endregion

        #region Neuter Dative
        [Theory]
        [InlineData(1, "pierwszemu")]
        [InlineData(2, "drugiemu")]
        [InlineData(3, "trzeciemu")]
        [InlineData(4, "czwartemu")]
        [InlineData(5, "piątemu")]
        [InlineData(6, "szóstemu")]
        [InlineData(7, "siódmemu")]
        [InlineData(8, "ósmemu")]
        [InlineData(9, "dziewiątemu")]
        [InlineData(10, "dziesiątemu")]
        [InlineData(11, "jedenastemu")]
        [InlineData(12, "dwunastemu")]
        [InlineData(13, "trzynastemu")]
        [InlineData(14, "czternastemu")]
        [InlineData(15, "piętnastemu")]
        [InlineData(16, "szesnastemu")]
        [InlineData(17, "siedemnastemu")]
        [InlineData(18, "osiemnastemu")]
        [InlineData(19, "dziewiętnastemu")]
        [InlineData(20, "dwudziestemu")]
        [InlineData(30, "trzydziestemu")]
        [InlineData(40, "czterdziestemu")]
        [InlineData(50, "pięćdziesiątemu")]
        [InlineData(60, "sześćdziesiątemu")]
        [InlineData(70, "siedemdziesiątemu")]
        [InlineData(80, "osiemdziesiątemu")]
        [InlineData(90, "dziewięćdziesiątemu")]
        [InlineData(21, "dwudziestemu pierwszemu")]
        [InlineData(32, "trzydziestemu drugiemu")]
        [InlineData(43, "czterdziestemu trzeciemu")]
        [InlineData(100, "setnemu")]
        [InlineData(200, "dwusetnemu")]
        [InlineData(300, "trzechsetnemu")]
        [InlineData(400, "czterechsetnemu")]
        [InlineData(500, "pięćsetnemu")]
        [InlineData(600, "sześćsetnemu")]
        [InlineData(700, "siedemsetnemu")]
        [InlineData(800, "osiemsetnemu")]
        [InlineData(900, "dziewięćsetnemu")]
        [InlineData(101, "sto pierwszemu")]
        [InlineData(202, "dwieście drugiemu")]
        [InlineData(310, "trzysta dziesiątemu")]
        [InlineData(412, "czterysta dwunastemu")]
        [InlineData(556, "pięćset pięćdziesiątemu szóstemu")]
        [InlineData(1000, "tysięcznemu")]
        [InlineData(1000000, "milionowemu")]
        [InlineData(1000000000, "miliardowemu")]
        [InlineData(1000000000000, "bilionowemu")]
        [InlineData(2000, "dwutysięcznemu")]
        [InlineData(5000, "pięciotysięcznemu")]
        [InlineData(101000, "stujednotysięcznemu")]
        [InlineData(206000, "dwóchsetsześciotysięcznemu")]
        [InlineData(1234567890, "miliard dwieście trzydzieści cztery miliony pięćset sześćdziesiąt siedem tysięcy osiemset dziewięćdziesiątemu")]
        [InlineData(1001001001, "miliard milion tysiąc pierwszemu")]
        [InlineData(413254, "czterysta trzynaście tysięcy dwieście pięćdziesiątemu czwartemu")]
        public void ToWords_Dative(long number, string expectedWords)
        {
            string resultWords = number.ToPolishWords()
                .Ordinal()
                .Gender(Gender.Neuter)
                .Case(Case.Dative);

            Assert.Equal(expectedWords, resultWords);
        }

        #endregion

        #region Neuter Accusative
        [Theory]
        [InlineData(1, "pierwsze")]
        [InlineData(2, "drugie")]
        [InlineData(3, "trzecie")]
        [InlineData(4, "czwarte")]
        [InlineData(5, "piąte")]
        [InlineData(6, "szóste")]
        [InlineData(7, "siódme")]
        [InlineData(8, "ósme")]
        [InlineData(9, "dziewiąte")]
        [InlineData(10, "dziesiąte")]
        [InlineData(11, "jedenaste")]
        [InlineData(12, "dwunaste")]
        [InlineData(13, "trzynaste")]
        [InlineData(14, "czternaste")]
        [InlineData(15, "piętnaste")]
        [InlineData(16, "szesnaste")]
        [InlineData(17, "siedemnaste")]
        [InlineData(18, "osiemnaste")]
        [InlineData(19, "dziewiętnaste")]
        [InlineData(20, "dwudzieste")]
        [InlineData(30, "trzydzieste")]
        [InlineData(40, "czterdzieste")]
        [InlineData(50, "pięćdziesiąte")]
        [InlineData(60, "sześćdziesiąte")]
        [InlineData(70, "siedemdziesiąte")]
        [InlineData(80, "osiemdziesiąte")]
        [InlineData(90, "dziewięćdziesiąte")]
        [InlineData(21, "dwudzieste pierwsze")]
        [InlineData(32, "trzydzieste drugie")]
        [InlineData(43, "czterdzieste trzecie")]
        [InlineData(100, "setne")]
        [InlineData(200, "dwusetne")]
        [InlineData(300, "trzechsetne")]
        [InlineData(400, "czterechsetne")]
        [InlineData(500, "pięćsetne")]
        [InlineData(600, "sześćsetne")]
        [InlineData(700, "siedemsetne")]
        [InlineData(800, "osiemsetne")]
        [InlineData(900, "dziewięćsetne")]
        [InlineData(101, "sto pierwsze")]
        [InlineData(202, "dwieście drugie")]
        [InlineData(310, "trzysta dziesiąte")]
        [InlineData(412, "czterysta dwunaste")]
        [InlineData(556, "pięćset pięćdziesiąte szóste")]
        [InlineData(1000, "tysięczne")]
        [InlineData(1000000, "milionowe")]
        [InlineData(1000000000, "miliardowe")]
        [InlineData(1000000000000, "bilionowe")]
        [InlineData(2000, "dwutysięczne")]
        [InlineData(5000, "pięciotysięczne")]
        [InlineData(101000, "stujednotysięczne")]
        [InlineData(206000, "dwóchsetsześciotysięczne")]
        [InlineData(1234567890, "miliard dwieście trzydzieści cztery miliony pięćset sześćdziesiąt siedem tysięcy osiemset dziewięćdziesiąte")]
        [InlineData(1001001001, "miliard milion tysiąc pierwsze")]
        [InlineData(413254, "czterysta trzynaście tysięcy dwieście pięćdziesiąte czwarte")]
        public void ToWords_Accusative(long number, string expectedWords)
        {
            string resultWords = number.ToPolishWords()
                .Ordinal()
                .Gender(Gender.Neuter)
                .Case(Case.Accusative);

            Assert.Equal(expectedWords, resultWords);
        }

        #endregion

        #region Neuter Instrumental
        [Theory]
        [InlineData(1, "pierwszym")]
        [InlineData(2, "drugim")]
        [InlineData(3, "trzecim")]
        [InlineData(4, "czwartym")]
        [InlineData(5, "piątym")]
        [InlineData(6, "szóstym")]
        [InlineData(7, "siódmym")]
        [InlineData(8, "ósmym")]
        [InlineData(9, "dziewiątym")]
        [InlineData(10, "dziesiątym")]
        [InlineData(11, "jedenastym")]
        [InlineData(12, "dwunastym")]
        [InlineData(13, "trzynastym")]
        [InlineData(14, "czternastym")]
        [InlineData(15, "piętnastym")]
        [InlineData(16, "szesnastym")]
        [InlineData(17, "siedemnastym")]
        [InlineData(18, "osiemnastym")]
        [InlineData(19, "dziewiętnastym")]
        [InlineData(20, "dwudziestym")]
        [InlineData(30, "trzydziestym")]
        [InlineData(40, "czterdziestym")]
        [InlineData(50, "pięćdziesiątym")]
        [InlineData(60, "sześćdziesiątym")]
        [InlineData(70, "siedemdziesiątym")]
        [InlineData(80, "osiemdziesiątym")]
        [InlineData(90, "dziewięćdziesiątym")]
        [InlineData(21, "dwudziestym pierwszym")]
        [InlineData(32, "trzydziestym drugim")]
        [InlineData(43, "czterdziestym trzecim")]
        [InlineData(100, "setnym")]
        [InlineData(200, "dwusetnym")]
        [InlineData(300, "trzechsetnym")]
        [InlineData(400, "czterechsetnym")]
        [InlineData(500, "pięćsetnym")]
        [InlineData(600, "sześćsetnym")]
        [InlineData(700, "siedemsetnym")]
        [InlineData(800, "osiemsetnym")]
        [InlineData(900, "dziewięćsetnym")]
        [InlineData(101, "sto pierwszym")]
        [InlineData(202, "dwieście drugim")]
        [InlineData(310, "trzysta dziesiątym")]
        [InlineData(412, "czterysta dwunastym")]
        [InlineData(556, "pięćset pięćdziesiątym szóstym")]
        [InlineData(1000, "tysięcznym")]
        [InlineData(1000000, "milionowym")]
        [InlineData(1000000000, "miliardowym")]
        [InlineData(1000000000000, "bilionowym")]
        [InlineData(2000, "dwutysięcznym")]
        [InlineData(5000, "pięciotysięcznym")]
        [InlineData(101000, "stujednotysięcznym")]
        [InlineData(206000, "dwóchsetsześciotysięcznym")]
        [InlineData(1234567890, "miliard dwieście trzydzieści cztery miliony pięćset sześćdziesiąt siedem tysięcy osiemset dziewięćdziesiątym")]
        [InlineData(1001001001, "miliard milion tysiąc pierwszym")]
        [InlineData(413254, "czterysta trzynaście tysięcy dwieście pięćdziesiątym czwartym")]
        public void ToWords_Instrumental(long number, string expectedWords)
        {
            string resultWords = number.ToPolishWords()
                .Ordinal()
                .Gender(Gender.Neuter)
                .Case(Case.Instrumental);

            Assert.Equal(expectedWords, resultWords);
        }

        #endregion

        #region Neuter Locative
        [Theory]
        [InlineData(1, "pierwszym")]
        [InlineData(2, "drugim")]
        [InlineData(3, "trzecim")]
        [InlineData(4, "czwartym")]
        [InlineData(5, "piątym")]
        [InlineData(6, "szóstym")]
        [InlineData(7, "siódmym")]
        [InlineData(8, "ósmym")]
        [InlineData(9, "dziewiątym")]
        [InlineData(10, "dziesiątym")]
        [InlineData(11, "jedenastym")]
        [InlineData(12, "dwunastym")]
        [InlineData(13, "trzynastym")]
        [InlineData(14, "czternastym")]
        [InlineData(15, "piętnastym")]
        [InlineData(16, "szesnastym")]
        [InlineData(17, "siedemnastym")]
        [InlineData(18, "osiemnastym")]
        [InlineData(19, "dziewiętnastym")]
        [InlineData(20, "dwudziestym")]
        [InlineData(30, "trzydziestym")]
        [InlineData(40, "czterdziestym")]
        [InlineData(50, "pięćdziesiątym")]
        [InlineData(60, "sześćdziesiątym")]
        [InlineData(70, "siedemdziesiątym")]
        [InlineData(80, "osiemdziesiątym")]
        [InlineData(90, "dziewięćdziesiątym")]
        [InlineData(21, "dwudziestym pierwszym")]
        [InlineData(32, "trzydziestym drugim")]
        [InlineData(43, "czterdziestym trzecim")]
        [InlineData(100, "setnym")]
        [InlineData(200, "dwusetnym")]
        [InlineData(300, "trzechsetnym")]
        [InlineData(400, "czterechsetnym")]
        [InlineData(500, "pięćsetnym")]
        [InlineData(600, "sześćsetnym")]
        [InlineData(700, "siedemsetnym")]
        [InlineData(800, "osiemsetnym")]
        [InlineData(900, "dziewięćsetnym")]
        [InlineData(101, "sto pierwszym")]
        [InlineData(202, "dwieście drugim")]
        [InlineData(310, "trzysta dziesiątym")]
        [InlineData(412, "czterysta dwunastym")]
        [InlineData(556, "pięćset pięćdziesiątym szóstym")]
        [InlineData(1000, "tysięcznym")]
        [InlineData(1000000, "milionowym")]
        [InlineData(1000000000, "miliardowym")]
        [InlineData(1000000000000, "bilionowym")]
        [InlineData(2000, "dwutysięcznym")]
        [InlineData(5000, "pięciotysięcznym")]
        [InlineData(101000, "stujednotysięcznym")]
        [InlineData(206000, "dwóchsetsześciotysięcznym")]
        [InlineData(1234567890, "miliard dwieście trzydzieści cztery miliony pięćset sześćdziesiąt siedem tysięcy osiemset dziewięćdziesiątym")]
        [InlineData(1001001001, "miliard milion tysiąc pierwszym")]
        [InlineData(413254, "czterysta trzynaście tysięcy dwieście pięćdziesiątym czwartym")]
        public void ToWords_Locative(long number, string expectedWords)
        {
            string resultWords = number.ToPolishWords()
                .Ordinal()
                .Gender(Gender.Neuter)
                .Case(Case.Locative);

            Assert.Equal(expectedWords, resultWords);
        }

        #endregion

        #region Neuter Vocative
        [Theory]
        [InlineData(1, "pierwsze")]
        [InlineData(2, "drugie")]
        [InlineData(3, "trzecie")]
        [InlineData(4, "czwarte")]
        [InlineData(5, "piąte")]
        [InlineData(6, "szóste")]
        [InlineData(7, "siódme")]
        [InlineData(8, "ósme")]
        [InlineData(9, "dziewiąte")]
        [InlineData(10, "dziesiąte")]
        [InlineData(11, "jedenaste")]
        [InlineData(12, "dwunaste")]
        [InlineData(13, "trzynaste")]
        [InlineData(14, "czternaste")]
        [InlineData(15, "piętnaste")]
        [InlineData(16, "szesnaste")]
        [InlineData(17, "siedemnaste")]
        [InlineData(18, "osiemnaste")]
        [InlineData(19, "dziewiętnaste")]
        [InlineData(20, "dwudzieste")]
        [InlineData(30, "trzydzieste")]
        [InlineData(40, "czterdzieste")]
        [InlineData(50, "pięćdziesiąte")]
        [InlineData(60, "sześćdziesiąte")]
        [InlineData(70, "siedemdziesiąte")]
        [InlineData(80, "osiemdziesiąte")]
        [InlineData(90, "dziewięćdziesiąte")]
        [InlineData(21, "dwudzieste pierwsze")]
        [InlineData(32, "trzydzieste drugie")]
        [InlineData(43, "czterdzieste trzecie")]
        [InlineData(100, "setne")]
        [InlineData(200, "dwusetne")]
        [InlineData(300, "trzechsetne")]
        [InlineData(400, "czterechsetne")]
        [InlineData(500, "pięćsetne")]
        [InlineData(600, "sześćsetne")]
        [InlineData(700, "siedemsetne")]
        [InlineData(800, "osiemsetne")]
        [InlineData(900, "dziewięćsetne")]
        [InlineData(101, "sto pierwsze")]
        [InlineData(202, "dwieście drugie")]
        [InlineData(310, "trzysta dziesiąte")]
        [InlineData(412, "czterysta dwunaste")]
        [InlineData(556, "pięćset pięćdziesiąte szóste")]
        [InlineData(1000, "tysięczne")]
        [InlineData(1000000, "milionowe")]
        [InlineData(1000000000, "miliardowe")]
        [InlineData(1000000000000, "bilionowe")]
        [InlineData(2000, "dwutysięczne")]
        [InlineData(5000, "pięciotysięczne")]
        [InlineData(101000, "stujednotysięczne")]
        [InlineData(206000, "dwóchsetsześciotysięczne")]
        [InlineData(1234567890, "miliard dwieście trzydzieści cztery miliony pięćset sześćdziesiąt siedem tysięcy osiemset dziewięćdziesiąte")]
        [InlineData(1001001001, "miliard milion tysiąc pierwsze")]
        [InlineData(413254, "czterysta trzynaście tysięcy dwieście pięćdziesiąte czwarte")]
        public void ToWords_Vocative(long number, string expectedWords)
        {
            string resultWords = number.ToPolishWords()
                .Ordinal()
                .Gender(Gender.Neuter)
                .Case(Case.Vocative);

            Assert.Equal(expectedWords, resultWords);
        }

        #endregion
    }
}
