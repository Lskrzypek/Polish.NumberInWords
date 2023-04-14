namespace Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers
{
    internal interface ISimpleNumbers
    {
        string Number_0 { get; }
        string Number_1 { get; }
        string Number_10 { get; }
        string Number_100 { get; }
        string Number_1000_pow_1 { get; }
        string Number_1000_pow_2 { get; }
        string Number_1000_pow_3 { get; }
        string Number_1000_pow_4 { get; }
        string Number_1000_pow_5 { get; }
        string Number_1000_pow_6 { get; }
        string Number_11 { get; }
        string Number_12 { get; }
        string Number_13 { get; }
        string Number_14 { get; }
        string Number_15 { get; }
        string Number_16 { get; }
        string Number_17 { get; }
        string Number_18 { get; }
        string Number_19 { get; }
        string Number_2 { get; }
        string Number_20 { get; }
        string Number_200 { get; }
        string Number_3 { get; }
        string Number_30 { get; }
        string Number_300 { get; }
        string Number_4 { get; }
        string Number_40 { get; }
        string Number_400 { get; }
        string Number_5 { get; }
        string Number_50 { get; }
        string Number_500 { get; }
        string Number_6 { get; }
        string Number_60 { get; }
        string Number_600 { get; }
        string Number_7 { get; }
        string Number_70 { get; }
        string Number_700 { get; }
        string Number_8 { get; }
        string Number_80 { get; }
        string Number_800 { get; }
        string Number_9 { get; }
        string Number_90 { get; }
        string Number_900 { get; }

        string Solve(long number);
        string SolveBigNumber(int powerOf1000);
    }
}