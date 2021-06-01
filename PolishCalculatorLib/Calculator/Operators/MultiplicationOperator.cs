
namespace ConsoleCalculator.Calculator.Operators
{
    /// <summary>
    /// Оператор умножения.
    /// </summary>
    public class MultiplicationOperator : Operator
    {
        public override bool IsTriggeringInput(string input)
        {
            return input.StartsWith("* ");
        }

        public override decimal Calculate(decimal left, decimal right)
        {
            return left * right;
        }
    }
}
