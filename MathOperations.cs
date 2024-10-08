using System;

public class MathOperations
{
    public int AddFive(int number)
    {
        return number + 5;
    }

    public int MultiplyByTwo(int number)
    {
        return number * 2;
    }

    public int SubtractThree(int number)
    {
        return number - 3;
        
    public void DivideByTwo(int number)
    {
        int result = number / 2;
        Console.WriteLine($"Result after dividing by 2: {result}");
    }


    public void MultiplyByThree(int input, out int result)
    {
        result = input * 3;
    }


    public void Multiply(int number)
    {
        int result = number * 2;
        Console.WriteLine($"Result of multiplying by 2: {result}");
    }

    public void Multiply(int number, int multiplier)
    {
        int result = number * multiplier;
        Console.WriteLine($"Result of multiplying by {multiplier}: {result}");
    }
}