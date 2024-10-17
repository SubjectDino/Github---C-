using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class MathOperations
    {
        public int Calculate(int number)
        {
            return number + 10;
        }

        public int Calculate(decimal number)
        {
            return (int)(number * 2);
        }

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
