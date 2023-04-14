using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Singular;

namespace Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Plural
{
    internal class PluralDative : SingularMasculineDative, IPluralDative
    {
        public override string Number_1000_pow_1 => "tysiącom";
        public override string Number_1000_pow_2 => "milionom";
        public override string Number_1000_pow_3 => "miliardom";
        public override string Number_1000_pow_4 => "bilionom";
        public override string Number_1000_pow_5 => "biliardom";
        public override string Number_1000_pow_6 => "trylionom";
    }
}
