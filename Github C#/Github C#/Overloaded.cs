using System;

public class Employee : Person, IQuittable
{
    public int Id { get; set; }

    public override void SayName()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }

    public void Quit()
    {
        Console.WriteLine($"{FirstName} {LastName} quit the job.");
    }

    public static bool operator ==(Employee emp1, Employee emp2)
    {
        if (ReferenceEquals(emp1, emp2))
        {
            return true;
        }

        if (emp1 is null || emp2 is null)
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
        if (obj is Employee emp)
        {
            return this.Id == emp.Id;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}

class Program
{
    static void Main()
    {
        Employee employee1 = new Employee() { FirstName = "John", LastName = "Doe", Id = 1 };
        Employee employee2 = new Employee() { FirstName = "Jane", LastName = "Doe", Id = 1 };

        if (employee1 == employee2)
        {
            Console.WriteLine("The employees have the same Id.");
        }
        else
        {
            Console.WriteLine("The employees have different Ids.");
        }
    }
}