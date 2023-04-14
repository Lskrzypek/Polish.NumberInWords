using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Singular;

namespace Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Plural
{
    internal class PluralAccusative : SingularMasculineAccusative, IPluralAccusative
    {
        public override string Number_1000_pow_1 => "tysiące";
        public override string Number_1000_pow_2 => "miliony";
        public override string Number_1000_pow_3 => "miliardy";
        public override string Number_1000_pow_4 => "biliony";
        public override string Number_1000_pow_5 => "biliardy";
        public override string Number_1000_pow_6 => "tryliony";
    }
}
