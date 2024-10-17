using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employeeString = new Employee<string>();
            employeeString.Things = new List<string> { "John", "Doe", "Jane" };

            Employee<int> employeeInt = new Employee<int>();
            employeeInt.Things = new List<int> { 100, 200, 300 };

            Console.WriteLine("String List:");
            foreach (var thing in employeeString.Things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("\nInteger List:");
            foreach (var thing in employeeInt.Things)
            {
                Console.WriteLine(thing);
            }
        }
    }
}