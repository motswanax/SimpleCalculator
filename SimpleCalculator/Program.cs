using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                Console.WriteLine("Enter first number: ");
                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("Enter the operator: ");
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                // TODO: Start logging exceptions
                Console.WriteLine(ex.Message);
            }
        }
    }
}
