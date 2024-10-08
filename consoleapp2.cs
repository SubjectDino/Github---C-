
using System;

public class MathOperations
{

    public int PerformOperation(int number)
    {
        return number + 10;
    }

    public int PerformOperation(decimal number)
    {
        return (int)(number * 3);
    }

    public int PerformOperation(string number)
    {
        int parsedNumber;
        bool isParsed = int.TryParse(number, out parsedNumber);

        if (isParsed)
        {
            return parsedNumber - 5;
        }
        else
        {
            throw new ArgumentException("The provided string is not a valid number.");
        }
    }
}