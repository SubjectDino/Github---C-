using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Please enter the current day of the week:");

            string userInput = Console.ReadLine();
            DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);

            Console.WriteLine($"You entered: {currentDay}");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Please enter an actual day of the week.");
        }
    }
}

public enum DaysOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}