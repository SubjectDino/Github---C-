using System;

class Program
{
    static void Main()
    {
        Console.Write("Please input your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Have you ever had a DUI? (t/f): ");
        bool dui = Console.ReadLine().ToLower() == "t";

        Console.Write("How many speeding tickets have you had? ");
        int speedingTickets = int.Parse(Console.ReadLine());

        bool qualified = age > 15 && !dui && speedingTickets <= 3;

        Console.WriteLine("Qualified?");
        Console.WriteLine(qualified);
    }
}
