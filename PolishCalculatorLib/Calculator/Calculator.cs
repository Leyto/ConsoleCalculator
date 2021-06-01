using ConsoleCalculator.Calculator.Operators;
using System;
using System.Collections.Generic;

namespace ConsoleCalculator.Calculator
{
    /// <summary>
    /// Основной класс калькулятора
    /// </summary>
    public class Calculator
    {
        private const char Separator = ' ';

        // Пока что обрабатывает только операции с двумя значениями
        private const int ParamsCount = 3;
        private static List<Operator> operators;


        static Calculator()
        {
            operators = new List<Operator>
            {
                new AdditionOperator(),
                new SubtractionOperator(),
                new MultiplicationOperator(),
                new DivisionOperator()
            };
        }

        public Calculator()
        { }

        public decimal ProcessUserInput(string input)
        {
            foreach (Operator op in operators)
            {
                if (op.IsTriggeringInput(input))
                {
                    var inputSymbolsArray = input.Split(Separator);

                    if (inputSymbolsArray.Length != ParamsCount)
                    {
                        throw new InvalidOperationException("Invalid Pparameters count.");
                    }

                    decimal left;
                    decimal right;
                    if (decimal.TryParse(inputSymbolsArray[1], out left) && decimal.TryParse(inputSymbolsArray[2], out right))
                    {
                        return op.Calculate(left, right);
                    }
                }
            }

            throw new InvalidOperationException("Invalid input, I don't know what \"" + input + "\" means.");
        }
    }
}
