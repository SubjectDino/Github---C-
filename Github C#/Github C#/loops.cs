using System;

class Program
{
    static void Main()
    {
        int whileCounter = 0;
        Console.WriteLine("Boolean comparison using a while loop:");
        while (whileCounter < 5)
        {
            Console.WriteLine($"whileCounter is {whileCounter}, which is less than 5");
            whileCounter++;
        }

        int doWhileCounter = 0;
        Console.WriteLine("\nBoolean comparison using a do-while loop:");
        do
        {
            Console.WriteLine($"doWhileCounter is {doWhileCounter}, which is less than 5");
            doWhileCounter++;
        }
        while (doWhileCounter < 5);
    }
}