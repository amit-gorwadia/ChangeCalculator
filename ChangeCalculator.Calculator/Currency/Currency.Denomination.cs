using System.Collections.Generic;

namespace ChangeCalculator.Calculator
{
    public partial class Currency : ICurrency
    {
        public IList<string> Denomination { get; set; }
    }
}
