using System;

namespace ChangeCalculator.Calculator
{
    public partial class Currency
    {
        public string Format(int count, decimal value)
        {
            return value > 0m
                ? value >= 1 ? string.Format("{0} X {1}{2}", count, Symbol, value)
                        : string.Format("{0} X {1}{2}", count, (int)Math.Floor(value * 100), Suffix)
                : string.Empty;
        }
    }
}
