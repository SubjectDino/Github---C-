using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class MathOperations
    {
        // Method for integer - adds 10 to the input integer
        public int Calculate(int number)
        {
            return number + 10;
        }

        // Method for decimal - multiplies the input decimal by 2 and returns the integer value
        public int Calculate(decimal number)
        {
            return (int)(number * 2);
        }

        // Method for string - tries to convert the string to an integer, then subtracts 5
        public int Calculate(string number)
        {
            int parsedNumber;
            bool isInteger = int.TryParse(number, out parsedNumber);

            if (isInteger)
            {
                return parsedNumber - 5;
            }
            else
            {
                throw new ArgumentException("Input string was not in the correct format.");
            }
        }
    }
}
