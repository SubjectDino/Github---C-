using System;

public interface IQuittable
{
    void Quit();
}
public class Employee : Person, IQuittable
{
    public override void SayName()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }

    public void Quit()
    {
        Console.WriteLine($"{FirstName} {LastName} has quit the job.");
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

        // Using polymorphism to create an IQuittable object
        IQuittable quittable = employee;

        // Call the Quit() method on the IQuittable object
        quittable.Quit();
    }
}