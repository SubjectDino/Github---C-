using System;

class Program
{
    static void Main()
    {
        MathOperations mathOperations = new MathOperations();

        Console.WriteLine("Please enter a number:");

        int userInput = int.Parse(Console.ReadLine());

        int resultAddFive = mathOperations.AddFive(userInput);
        Console.WriteLine($"Result of adding 5: {resultAddFive}");

        int resultMultiplyByTwo = mathOperations.MultiplyByTwo(userInput);
        Console.WriteLine($"Result of multiplying by 2: {resultMultiplyByTwo}");

        int resultSubtractThree = mathOperations.SubtractThree(userInput);
        Console.WriteLine($"Result of subtracting 3: {resultSubtractThree}");
        Console.WriteLine("Enter an integer:");
        int userInputInt = int.Parse(Console.ReadLine());
        int resultInt = mathOperations.PerformOperation(userInputInt);
        Console.WriteLine($"Result of adding 10 to the integer: {resultInt}");

        //Main method submission assignment
        
        Console.WriteLine("Enter a decimal:");
        decimal userInputDecimal = decimal.Parse(Console.ReadLine());
        int resultDecimal = mathOperations.PerformOperation(userInputDecimal);
        Console.WriteLine($"Result of multiplying the decimal by 3: {resultDecimal}");


        Console.WriteLine("Enter a string that represents a number:");
        string userInputString = Console.ReadLine();
        try
        {
            int resultString = mathOperations.PerformOperation(userInputString);
            Console.WriteLine($"Result of subtracting 5 from the string number: {resultString}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
