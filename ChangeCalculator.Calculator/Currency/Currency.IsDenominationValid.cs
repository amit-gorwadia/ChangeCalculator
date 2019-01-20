namespace ChangeCalculator.Calculator
{
    public partial class Currency
    {
        public bool IsDenominationValid()
        {
            var decimalList = ConvertDenominationToDecimal();
            return decimalList != null ? Denomination.Count == decimalList.Count : false;            
        }
    }
}
