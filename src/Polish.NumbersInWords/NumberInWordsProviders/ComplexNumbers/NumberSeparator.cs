namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers
{
    internal class NumberSeparator : INumberSeparator
    {
        public NumberElements Separate(long number)
        {
            var last2digs = number % 100;

            var hundreds = number > 99
                ? (number % 1_000 - last2digs) / 100
                : 0;

            var number_1000_pow_1 = number > 999
                ? (number % 1_000_000 - hundreds * 100 - last2digs) / 1_000
                : 0;

            var number_1000_pow_2 = number > 999_999
                ? (number % 1_000_000_000 - hundreds * 100 - last2digs - number_1000_pow_1) / 1_000_000
                : 0;

            var number_1000_pow_3 = number > 999_999_999
                ? (number % 1_000_000_000_000 - hundreds * 100 - last2digs - number_1000_pow_1 - number_1000_pow_2) / 1_000_000_000
                : 0;

            var number_1000_pow_4 = number > 999_999_999_999
                ? (number % 1_000_000_000_000_000 - hundreds * 100 - last2digs - number_1000_pow_1 - number_1000_pow_2 - number_1000_pow_3) / 1_000_000_000_000
                : 0;

            var number_1000_pow_5 = number > 999_999_999_999_999
                ? (number % 1_000_000_000_000_000_000 - hundreds * 100 - last2digs - number_1000_pow_1 - number_1000_pow_2 - number_1000_pow_3 - number_1000_pow_4) / 1_000_000_000_000_000
                : 0;

            var number_1000_pow_6 = number > 999_999_999_999_999_999
                ? (number - hundreds * 100 - last2digs - number_1000_pow_1 - number_1000_pow_2 - number_1000_pow_3 - number_1000_pow_4 - number_1000_pow_5) / 1_000_000_000_000_000_000
                : 0;

            return new NumberElements()
            {
                Last2digs = (int)last2digs,
                Hundreds = (int)hundreds,
                Thousands = new (int PowerOf1000, int Count)[]
                {
                    (1, (int)number_1000_pow_1),
                    (2, (int)number_1000_pow_2),
                    (3, (int)number_1000_pow_3),
                    (4, (int)number_1000_pow_4),
                    (5, (int)number_1000_pow_5),
                    (6, (int)number_1000_pow_6),
                }
            };
        }
    }
}
