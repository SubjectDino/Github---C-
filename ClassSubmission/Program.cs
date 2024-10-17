using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to divide by 2:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int dividedResult;
            MathOperations.DivideByTwo(userInput, out dividedResult);
            Console.WriteLine("Your number divided by 2 is: " + dividedResult);

            Console.WriteLine("\nEnter two numbers to add:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sumResult;
            MathOperations.AddNumbers(num1, num2, out sumResult);
            Console.WriteLine($"The sum of {num1} and {num2} is: {sumResult}");

            Console.WriteLine("\nOverloaded methods:");
            int intSum = MathOperations.AddNumbers(5, 10);
            Console.WriteLine("Sum of 5 and 10 (int): " + intSum);

            decimal decimalSum = MathOperations.AddNumbers(5.5m, 10.5m);
            Console.WriteLine("Sum of 5.5 and 10.5 (decimal): " + decimalSum);
        }
    }