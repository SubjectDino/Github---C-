using System;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id { get; set; }

    public Employee(string firstName, string lastName, int id)
    {
        FirstName = firstName;
        LastName = lastName;
        Id = id;
    }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee("Joe", "Smith", 1),
            new Employee("Jane", "Doe", 2),
            new Employee("Joe", "Johnson", 3),
            new Employee("Anna", "Williams", 4),
            new Employee("Mark", "Brown", 5),
            new Employee("Emily", "Davis", 6),
            new Employee("Chris", "Miller", 7),
            new Employee("Sarah", "Taylor", 8),
            new Employee("Joe", "Wilson", 9),
            new Employee("Paul", "Jones", 10)
        };

        List<Employee> joeEmployees = new List<Employee>();
        foreach (Employee emp in employees)
        {
            if (emp.FirstName == "Joe")
            {
                joeEmployees.Add(emp);
            }
        }

        Console.WriteLine("Employees named 'Joe' (using foreach loop):");
        foreach (var joe in joeEmployees)
        {
            Console.WriteLine($"ID: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
        }

        List<Employee> joeEmployeesLambda = employees.Where(e => e.FirstName == "Joe").ToList();

        Console.WriteLine("\nEmployees named 'Joe' (using lambda expression):");
        foreach (var joe in joeEmployeesLambda)
        {
            Console.WriteLine($"ID: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
        }

        List<Employee> employeesWithIdGreaterThanFive = employees.Where(e => e.Id > 5).ToList();

        Console.WriteLine("\nEmployees with ID greater than 5:");
        foreach (var emp in employeesWithIdGreaterThanFive)
        {
            Console.WriteLine($"ID: {emp.Id}, Name: {emp.FirstName} {emp.LastName}");
        }
    }
}