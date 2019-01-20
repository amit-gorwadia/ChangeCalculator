using System.Collections.Generic;

namespace ChangeCalculator.Calculator
{
    public partial interface ICurrency
    {
        IList<decimal> ConvertDenominationToDecimal();        
    }
}
