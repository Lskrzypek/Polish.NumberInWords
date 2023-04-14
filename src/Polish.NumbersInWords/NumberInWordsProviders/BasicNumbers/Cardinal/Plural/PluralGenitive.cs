using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Singular;

namespace Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Plural
{
    internal class PluralGenitive : SingularMasculineGenitive, IPluralGenitive
    {
        public override string Number_1000_pow_1 => "tysięcy";
        public override string Number_1000_pow_2 => "milionów";
        public override string Number_1000_pow_3 => "miliardów";
        public override string Number_1000_pow_4 => "bilionów";
        public override string Number_1000_pow_5 => "biliardów";
        public override string Number_1000_pow_6 => "trylionów";
    }
}
