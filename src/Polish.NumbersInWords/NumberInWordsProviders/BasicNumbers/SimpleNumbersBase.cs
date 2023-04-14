namespace Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers
{
    internal abstract class SimpleNumbersBase : ISimpleNumbers
    {
        public abstract string Number_0 { get; }
        public abstract string Number_1 { get; }
        public abstract string Number_2 { get; }
        public abstract string Number_3 { get; }
        public abstract string Number_4 { get; }
        public abstract string Number_5 { get; }
        public abstract string Number_6 { get; }
        public abstract string Number_7 { get; }
        public abstract string Number_8 { get; }
        public abstract string Number_9 { get; }
        public abstract string Number_10 { get; }
        public abstract string Number_11 { get; }
        public abstract string Number_12 { get; }
        public abstract string Number_13 { get; }
        public abstract string Number_14 { get; }
        public abstract string Number_15 { get; }
        public abstract string Number_16 { get; }
        public abstract string Number_17 { get; }
        public abstract string Number_18 { get; }
        public abstract string Number_19 { get; }
        public abstract string Number_20 { get; }
        public abstract string Number_30 { get; }
        public abstract string Number_40 { get; }
        public abstract string Number_50 { get; }
        public abstract string Number_60 { get; }
        public abstract string Number_70 { get; }
        public abstract string Number_80 { get; }
        public abstract string Number_90 { get; }
        public abstract string Number_100 { get; }
        public abstract string Number_200 { get; }
        public abstract string Number_300 { get; }
        public abstract string Number_400 { get; }
        public abstract string Number_500 { get; }
        public abstract string Number_600 { get; }
        public abstract string Number_700 { get; }
        public abstract string Number_800 { get; }
        public abstract string Number_900 { get; }
        public abstract string Number_1000_pow_1 { get; }
        public abstract string Number_1000_pow_2 { get; }
        public abstract string Number_1000_pow_3 { get; }
        public abstract string Number_1000_pow_4 { get; }
        public abstract string Number_1000_pow_5 { get; }
        public abstract string Number_1000_pow_6 { get; }

        public string Solve(long number)
        {
            switch (number)
            {
                case 0: return Number_0;
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
                case 1_000: return Number_1000_pow_1;
                case 1_000_000: return Number_1000_pow_2;
                case 1_000_000_000: return Number_1000_pow_3;
                case 1_000_000_000_000: return Number_1000_pow_4;
                case 1_000_000_000_000_000: return Number_1000_pow_5;
                case 1_000_000_000_000_000_000: return Number_1000_pow_6;

                default: return "";
            };
        }

        public string SolveBigNumber(int powerOf1000)
        {
            switch (powerOf1000)
            {
                case 1: return Number_1000_pow_1;
                case 2: return Number_1000_pow_2;
                case 3: return Number_1000_pow_3;
                case 4: return Number_1000_pow_4;
                case 5: return Number_1000_pow_5;
                case 6: return Number_1000_pow_6;

                default: return "";
            }
        }
    }
}