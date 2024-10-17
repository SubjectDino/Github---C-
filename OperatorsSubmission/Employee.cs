using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (ReferenceEquals(emp1, emp2))
            {
                return true;
            }

            if ((object)emp1 == null || (object)emp2 == null)
            {
                return false;
            }

            return emp1.Id == emp2.Id;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Employee employee = (Employee)obj;
            return Id == employee.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
