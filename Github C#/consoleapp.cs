using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> integerList = new List<int>() { 10, 20, 30, 40, 50 };

        Console.WriteLine("Please enter a number to divide each number in the list by:");

        string userInput = Console.ReadLine();
        int divisor;

        try
        {
            divisor = int.Parse(userInput);

            foreach (int number in integerList)
            {
                int result = number / divisor;
                Console.WriteLine($"{number} divided by {divisor} equals {result}");
            }
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: You cannot divide by zero.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Please enter a valid integer.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("The program has emerged from the try/catch block and continued execution.");
        }

        Console.WriteLine("Program execution continues...");
    }
}