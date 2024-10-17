using System;
using System.Collections.Generic;

public class Employee<T> : Person, IQuittable
{
    public int Id { get; set; }

    public List<T> Things { get; set; }

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
        Employee<string> employee1 = new Employee<string>()
        {
            FirstName = "John",
            LastName = "Doe",
            Things = new List<string> { "Laptop", "Notebook", "Pen" }
        };

        Console.WriteLine($"{employee1.FirstName} {employee1.LastName}'s things:");
        foreach (string thing in employee1.Things)
        {
            Console.WriteLine(thing);
        }

        Employee<int> employee2 = new Employee<int>()
        {
            FirstName = "Jane",
            LastName = "Doe",
            Things = new List<int> { 1, 2, 3, 4 }
        };

        Console.WriteLine($"\n{employee2.FirstName} {employee2.LastName}'s things:");
        foreach (int thing in employee2.Things)
        {
            Console.WriteLine(thing);
        }
    }
}