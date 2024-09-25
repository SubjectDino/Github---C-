using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Anonymous Income Comparison Program");

        // Person 1
        Console.WriteLine("Person 1");
        Console.Write("Hourly Rate? ");
        float hourlyRatePerson1 = float.Parse(Console.ReadLine());

        Console.Write("Hours worked per week? ");
        float hoursPerWeekPerson1 = float.Parse(Console.ReadLine());

        // Person 2
        Console.WriteLine("Person 2");
        Console.Write("Hourly Rate? ");
        float hourlyRatePerson2 = float.Parse(Console.ReadLine());

        Console.Write("Hours worked per week? ");
        float hoursPerWeekPerson2 = float.Parse(Console.ReadLine());

        // Calculate Annual Salaries
        float annualSalaryPerson1 = hourlyRatePerson1 * hoursPerWeekPerson1 * 52;
        float annualSalaryPerson2 = hourlyRatePerson2 * hoursPerWeekPerson2 * 52;

        // Output Annual Salaries
        Console.WriteLine($"Annual salary of Person 1:\n{annualSalaryPerson1}");
        Console.WriteLine($"Annual salary of Person 2:\n{annualSalaryPerson2}");

        // Comparison
        bool makesMore = annualSalaryPerson1 > annualSalaryPerson2;

        Console.WriteLine("Does Person 1 make more money than Person 2?");
        Console.WriteLine(makesMore);
    }
}