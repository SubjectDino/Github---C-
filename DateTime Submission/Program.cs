using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current date and time: " + currentDateTime);

            Console.WriteLine("Please enter a number of hours:");
            int hours = int.Parse(Console.ReadLine());

            DateTime futureDateTime = currentDateTime.AddHours(hours);
            Console.WriteLine("In " + hours + " hours, the date and time will be: " + futureDateTime);
        }
    }
}
}
