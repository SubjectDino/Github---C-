using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOps = new MathOperations();

            int result1 = mathOps.Calculate(10);
            Console.WriteLine("Result of integer calculation (10 + 10): " + result1);

            int result2 = mathOps.Calculate(12.5m);
            Console.WriteLine("Result of decimal calculation (12.5 * 2): " + result2);

            int result3 = mathOps.Calculate("20");
            Console.WriteLine("Result of string calculation ('20' - 5): " + result3);
        }
    }
}
