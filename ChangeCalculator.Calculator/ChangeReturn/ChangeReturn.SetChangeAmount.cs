namespace ChangeCalculator.Calculator
{
    public partial class ChangeReturn
    {
        public bool SetChangeAmount()
        {
            ApplyValidation();
            if (ErrorMessage.Count > 0) return false;
            ChangeAmount = decimal.Parse(PaymentAmount) - decimal.Parse(ProductCost);
            return true;
        }
    }
}
