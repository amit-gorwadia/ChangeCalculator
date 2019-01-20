namespace ChangeCalculator.Calculator
{
    public partial interface ICurrency
    {
        string Format(int count, decimal value);
    }
}
