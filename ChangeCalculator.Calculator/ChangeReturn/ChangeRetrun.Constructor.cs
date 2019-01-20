using System.Collections.Generic;

namespace ChangeCalculator.Calculator
{
    public partial class ChangeReturn : IChangeReturn
    {
        ICurrency currency;
        public ChangeReturn(ICurrency currency)
        {
            this.currency = currency;
            ErrorMessage = new List<string>();
        }
    }
}
