using Polish.NumbersInWords.NumberInWordsProviders.BasicNumbers;

namespace Polish.NumbersInWords.NumberInWordsProviders.ComplexNumbers.Ordinal.Core
{
    internal class OrdinalNumberProviderFactory : IOrdinalNumberProviderFactory
    {
        private readonly INumberSeparator _numberSeparator;
        private readonly IBigNumbersPrefixes _bigNumbersPrefixes;
        protected readonly INumberInWordsConfiguration _configuration;

        public OrdinalNumberProviderFactory(INumberSeparator numberSeparator, IBigNumbersPrefixes bigNumbersPrefixes,
            INumberInWordsConfiguration configuration)
        {
            _numberSeparator = numberSeparator ?? throw new System.ArgumentNullException(nameof(numberSeparator));
            _bigNumbersPrefixes = bigNumbersPrefixes ?? throw new System.ArgumentNullException(nameof(bigNumbersPrefixes));
            _configuration = configuration ?? throw new System.ArgumentNullException(nameof(configuration));
        }

        public IOrdinalNumberProvider Create(ISimpleNumbers basicOrdinalNumbers,
                                           ISimpleNumbers basicCardinalNumbers,
                                           ISimpleNumbers from_2_to_4_thousands,
                                           ISimpleNumbers up_to_4_thousands,
                                           ISimpleNumbers hundreds)
        {
            return new OrdinalNumberProvider(
                _numberSeparator,
                basicOrdinalNumbers,
                basicCardinalNumbers,
                from_2_to_4_thousands,
                up_to_4_thousands,
                _bigNumbersPrefixes,
                hundreds,
                _configuration);
        }
    }
}
