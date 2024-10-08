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
    }
}