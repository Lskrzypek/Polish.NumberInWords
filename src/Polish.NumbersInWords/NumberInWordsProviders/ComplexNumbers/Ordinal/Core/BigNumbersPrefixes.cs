namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal.Core
{
    internal class BigNumbersPrefixes : IBigNumbersPrefixes
    {
        public string Number_1 => "jedno";
        public string Number_2 => "dwu";
        public string Number_3 => "trój";
        public string Number_4 => "cztero";
        public string Number_5 => "pięcio";
        public string Number_6 => "sześcio";
        public string Number_7 => "siedmio";
        public string Number_8 => "ośmio";
        public string Number_9 => "dziewięcio";
        public string Number_10 => "dziesięcio";
        public string Number_11 => "jedenasto";
        public string Number_12 => "dwunasto";
        public string Number_13 => "trzynasto";
        public string Number_14 => "czternasto";
        public string Number_15 => "piętnasto";
        public string Number_16 => "szesnasto";
        public string Number_17 => "siedemnasto";
        public string Number_18 => "osiemnasto";
        public string Number_19 => "dziewiętnasto";
        public string Number_20 => "dwudziesto";
        public string Number_30 => "trzydziesto";
        public string Number_40 => "czterdziesto";
        public string Number_50 => "pięćdziesięcio";
        public string Number_60 => "sześćdziesięcio";
        public string Number_70 => "siedemdziesięcio";
        public string Number_80 => "osiemdziesięcio";
        public string Number_90 => "dziewięćdziesięcio";
        public string Number_100 => "stu";
        public string Number_200 => "dwóchset";
        public string Number_300 => "trzechset";
        public string Number_400 => "czterech";
        public string Number_500 => "pięćset";
        public string Number_600 => "sześćset";
        public string Number_700 => "siedemset";
        public string Number_800 => "osiemset";
        public string Number_900 => "dziewięćset";

        public string Solve(long number)
        {
            switch (number)
            {
                case 1: return Number_1;
                case 2: return Number_2;
                case 3: return Number_3;
                case 4: return Number_4;
                case 5: return Number_5;
                case 6: return Number_6;
                case 7: return Number_7;
                case 8: return Number_8;
                case 9: return Number_9;
                case 10: return Number_10;
                case 11: return Number_11;
                case 12: return Number_12;
                case 13: return Number_13;
                case 14: return Number_14;
                case 15: return Number_15;
                case 16: return Number_16;
                case 17: return Number_17;
                case 18: return Number_18;
                case 19: return Number_19;
                case 20: return Number_20;
                case 30: return Number_30;
                case 40: return Number_40;
                case 50: return Number_50;
                case 60: return Number_60;
                case 70: return Number_70;
                case 80: return Number_80;
                case 90: return Number_90;
                case 100: return Number_100;
                case 200: return Number_200;
                case 300: return Number_300;
                case 400: return Number_400;
                case 500: return Number_500;
                case 600: return Number_600;
                case 700: return Number_700;
                case 800: return Number_800;
                case 900: return Number_900;

                default: return "";
            };
        }
    }
}
