using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    public static class MathOperations
    {
        public static void DivideByTwo(int number, out int result)
        {
            result = number / 2;
        }

        public static void AddNumbers(int number1, int number2, out int sum)
        {
            sum = number1 + number2;
        }

        public static int AddNumbers(int number1, int number2)
        {
            return number1 + number2;
        }

        public static decimal AddNumbers(decimal number1, decimal number2)
        {
            return number1 + number2;
        }
    }
}
