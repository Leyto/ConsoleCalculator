
namespace ConsoleCalculator.Calculator.Operators
{
    /// <summary>
    /// Оператор вычитания.
    /// </summary>
    public class SubtractionOperator : Operator
    {
        public override bool IsTriggeringInput(string input)
        {
            return input.StartsWith("- ");
        }

        public override decimal Calculate(decimal left, decimal right)
        {
            return left - right;
        }
    }
}
