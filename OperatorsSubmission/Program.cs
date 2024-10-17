using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee employee2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };

            if (employee1 == employee2)
            {
                Console.WriteLine("Both employees have the same Id.");
            }
            else
            {
                Console.WriteLine("The employees have different Ids.");
            }

            employee2.Id = 1;
            if (employee1 == employee2)
            {
                Console.WriteLine("Now both employees have the same Id.");
            }
            else
            {
                Console.WriteLine("The employees still have different Ids.");
            }
        }
    }
}
