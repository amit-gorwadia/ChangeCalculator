using System.Collections.Generic;

namespace ChangeCalculator.Calculator
{
    public partial interface IChangeReturn
    {
        IList<string> ErrorMessage { get; set; }
    }
}
