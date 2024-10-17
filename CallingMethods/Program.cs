using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number
            Console.WriteLine("Enter a number to perform math operations on:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the AddTen method and display the result
            int result1 = mathOps.AddTen(userInput);
            Console.WriteLine("After adding 10: " + result1);

            // Call the MultiplyByTwo method and display the result
            int result2 = mathOps.MultiplyByTwo(userInput);
            Console.WriteLine("After multiplying by 2: " + result2);

            // Call the SubtractFive method and display the result
            int result3 = mathOps.SubtractFive(userInput);
            Console.WriteLine("After subtracting 5: " + result3);
        }
    }
}
