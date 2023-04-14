using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Singular;

namespace Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers.Cardinal.Plural
{
    internal class PluralInstrumental : SingularMasculineNominative, IPluralInstrumental
    {
        public override string Number_1000_pow_1 => "tysiącami";
        public override string Number_1000_pow_2 => "milionami";
        public override string Number_1000_pow_3 => "miliardami";
        public override string Number_1000_pow_4 => "bilionami";
        public override string Number_1000_pow_5 => "biliardami";
        public override string Number_1000_pow_6 => "trylionami";
    }
}
