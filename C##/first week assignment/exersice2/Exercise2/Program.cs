using System;

namespace MathOperations
{
    public class Calculator
    {
        public static void PerformOperation(double? num1, double? num2, string operation)
        {
            try
            {
                double operand1 = num1 ?? 0; 
                double operand2 = num2 ?? 0; 

                double result;

                switch (operation)
                {
                    case "+":
                        result = operand1 + operand2;
                        Console.WriteLine($"Result of {operand1} + {operand2} = {result}");
                        break;

                    case "-":
                        result = operand1 - operand2;
                        Console.WriteLine($"Result of {operand1} - {operand2} = {result}");
                        break;

                    case "*":
                        result = operand1 * operand2;
                        Console.WriteLine($"Result of {operand1} * {operand2} = {result}");
                        break;

                    case "/":
                        if (operand2 != 0)
                        {
                            result = operand1 / operand2;
                            Console.WriteLine($"Result of {operand1} / {operand2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Division by zero is not allowed.");
                        }
                        break;

                    case "^":
                        result = Math.Pow(operand1, operand2);
                        Console.WriteLine($"Result of {operand1} ^ {operand2} = {result}");
                        break;

                    case "sqrt":
                        if (num1.HasValue)
                        {
                            result = Math.Sqrt(operand1);
                            Console.WriteLine($"Square root of {operand1} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Cannot calculate square root of a null value.");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid operation. Please use +, -, *, /, ^, or sqrt.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first number (or press Enter to leave it null):");
            string input1 = Console.ReadLine();
            double? num1 = string.IsNullOrEmpty(input1) ? (double?)null : double.Parse(input1);

            Console.WriteLine("Enter second number (or press Enter to leave it null):");
            string input2 = Console.ReadLine();
            double? num2 = string.IsNullOrEmpty(input2) ? (double?)null : double.Parse(input2);

            Console.WriteLine("Enter operation (+, -, *, /, ^, sqrt):");
            string operation = Console.ReadLine();

            PerformOperation(num1, num2, operation);
        }
    }
}
