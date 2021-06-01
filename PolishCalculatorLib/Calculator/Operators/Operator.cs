using System.Collections.Generic;

namespace ConsoleCalculator.Calculator.Operators
{
    /// <summary>
    /// Описание для классов операторов.
    /// </summary>
    public abstract class Operator
    {
        public abstract decimal Calculate(decimal left, decimal right);

        public abstract bool IsTriggeringInput(string input);
    }
}
