using System.Collections.Generic;
using System.Linq;

namespace ChangeCalculator.Calculator
{
    public partial class ChangeReturn
    {
        public IList<decimal> GetRequiredDenomination()
        {
            IList<decimal> requiredDenomination = new List<decimal>();
            var denomination = currency.ConvertDenominationToDecimal().ToList();
            if (denomination.Count > 0)
            {
                if (ChangeAmount > 1)
                    denomination.ForEach(d => requiredDenomination.Add(d));                    
                else
                    denomination.SkipWhile(x => x > 5m).ToList().ForEach(x => requiredDenomination.Add(x / (ChangeAmount < 0.10m ? 100m : 10m)));
            }
            return requiredDenomination;
        }
    }
}
