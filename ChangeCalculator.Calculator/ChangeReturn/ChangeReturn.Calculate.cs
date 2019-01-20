using System;
using System.Collections.Generic;

namespace ChangeCalculator.Calculator
{
    public partial class ChangeReturn
    {
        public IList<string> Calculate()
        {
            var result = new List<string>();
            if (ChangeAmount > 0.00m && currency.Denomination.Count > 0)
            {
                var requiredDenomination = new List<decimal>();
                while (ChangeAmount != 0.00m)
                {                    
                    requiredDenomination = (List<decimal>) GetRequiredDenomination();
                    requiredDenomination.ForEach(nominal =>
                    {
                        var nominalCount = (int)Math.Floor(ChangeAmount / nominal);
                        ChangeAmount -= nominalCount * nominal;
                        if (nominalCount > 0) result.Add(currency.Format(nominalCount, nominal));
                    });
                }
            }
            if (result.Count > 0) result.Insert(0, "Your Change is/are :");
            return result;
        }
    }
}
