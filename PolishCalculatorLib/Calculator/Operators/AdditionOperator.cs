
namespace ConsoleCalculator.Calculator.Operators
{
    /// <summary>
    /// Оператор сложения.
    /// </summary>
    public class AdditionOperator : Operator
    {
        public override decimal Calculate(decimal left, decimal right)
        {
            return left + right;
        }

        public override bool IsTriggeringInput(string input)
        {
            return input.StartsWith("+ ");
        }
    }
}
