using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee { FirstName = "John", LastName = "Doe" };

            IQuittable quittable = employee;

            quittable.Quit();
        }
    }
}
