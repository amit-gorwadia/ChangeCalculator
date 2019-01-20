using System.Collections.Generic;

namespace ChangeCalculator.Calculator
{
    public partial interface IChangeReturn
    {
        IList<decimal> GetRequiredDenomination();
    }
}
