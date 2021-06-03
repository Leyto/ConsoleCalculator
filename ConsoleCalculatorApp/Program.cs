using System;

namespace ConsoleCalculator
{
    class Program
    {
        private const string PROMPT = "Input operation > ";

        static void Main(string[] args)
        {
            Calculator.Calculator calculator = new Calculator.Calculator();

            Console.Write($"Welcome to Polish calculator! Plesse input operation in format: <operator> <left_decimal> <right_decimal>. \n Type q to quit. \n");

            Console.Write(PROMPT);

            string input;
            while ((input = Console.ReadLine()) != null)
            {
                string cleanInput = input.ToLower();

                if (cleanInput == "q")
                {
                    Environment.Exit(0);
                }
                else
                {
                    try
                    {
                        var calculatorOutput = calculator.ProcessUserInput(cleanInput);
                        Console.WriteLine(calculatorOutput);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("ERROR: " + e.Message);
                    }
                }

                Console.Write(PROMPT);
            }
        }
    }
}
