using System;

public abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public abstract void SayName();
}

public class Employee : Person
{
    // Implementing the SayName() method
    public override void SayName()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}

class Program
{
    static void Main()
    {
        // Instantiate and initialize an Employee object
        Employee employee = new Employee()
        {
            FirstName = "Sample",
            LastName = "Student"
        };

        // Call the SayName() method
        employee.SayName();
    }
}