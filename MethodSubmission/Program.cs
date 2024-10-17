using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOps = new MathOperations();

            Console.WriteLine("Enter the first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number (or press Enter to skip):");
            string secondInput = Console.ReadLine();

            int result;
            if (string.IsNullOrEmpty(secondInput))
            {
                result = mathOps.AddNumbers(firstNumber);
            }
            else
            {
                int secondNumber = Convert.ToInt32(secondInput);
                result = mathOps.AddNumbers(firstNumber, secondNumber);
            }
            Console.WriteLine("The result is: " + result);
        }
}
