using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Singular;

namespace Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Plural
{
    internal class PluralLocative : SingularMasculineLocative, IPluralLocative
    {
        public override string Number_1000_pow_1 => "tysiącach";
        public override string Number_1000_pow_2 => "milionach";
        public override string Number_1000_pow_3 => "miliardach";
        public override string Number_1000_pow_4 => "bilionach";
        public override string Number_1000_pow_5 => "biliardach";
        public override string Number_1000_pow_6 => "trylionach";
    }
}
