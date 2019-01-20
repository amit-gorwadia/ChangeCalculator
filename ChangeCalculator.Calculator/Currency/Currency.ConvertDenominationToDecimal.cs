using System.Collections.Generic;
using System.Linq;

namespace ChangeCalculator.Calculator
{
    public partial class Currency
    {
        public IList<decimal> ConvertDenominationToDecimal()
        {
            if (Denomination.Count > 0)
            {
                decimal x = 0m;
                var decimalList = Denomination.Where(str => decimal.TryParse(str, out x))
                                    .Select(str => x)
                                    .ToList();
                return decimalList;
            }
            return null;
        }
    }
}
