namespace ChangeCalculator.Calculator
{
    public partial class ChangeReturn
    {
        public void ApplyValidation()
        {
            decimal _out;
            bool Valid;

            #region "Product Cost Validation"
            Valid = !string.IsNullOrWhiteSpace(ProductCost) ?
                decimal.TryParse(ProductCost, out _out) : false;
            if(!Valid)
                ErrorMessage.Add("Invalid product cost.");
            #endregion

            #region "Payment Amount Validation"
            Valid = !string.IsNullOrWhiteSpace(PaymentAmount) ?
                decimal.TryParse(PaymentAmount, out _out) : false;
            if (!Valid)
            {
                ErrorMessage.Add("Invalid payment amount.");
            }
            else
            {
                if (ErrorMessage.Count <= 0)
                {
                    if (decimal.Parse(PaymentAmount) < decimal.Parse(ProductCost))
                        ErrorMessage.Add("Insufficient payment amount.");
                }                
            }
            #endregion

            #region "Currency Denomination Validation"
            if (!currency.IsDenominationValid())
                ErrorMessage.Add(string.Format("Invalid currency denomination value. [{0}]", string.Join(",", currency.Denomination)));
            #endregion
        }
    }
}
