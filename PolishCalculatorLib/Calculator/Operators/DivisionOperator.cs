using System;

namespace ConsoleCalculator.Calculator.Operators
{
    /// <summary>
    /// Оператор деления.
    /// </summary>
    public class DivisionOperator : Operator
    {
        public override bool IsTriggeringInput(string input)
        {
            return input.StartsWith("/ ");
        }

        public override decimal Calculate(decimal left, decimal right)
        {
            if (right == 0)
            {
                throw new InvalidOperationException("Arithmetic error: Division by zero");
            }

            return left / right;
        }
    }
}
