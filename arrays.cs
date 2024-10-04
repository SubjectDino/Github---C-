csharp
Copy code
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        string[] stringArray = { "cambrian", "ordovician", "silurian", "devonian", "carboniferous" };
        Console.WriteLine("Select an index of the string array:");
        int stringIndex = Convert.ToInt32(Console.ReadLine());

        if (stringIndex >= 0 && stringIndex < stringArray.Length)
        {
            Console.WriteLine($"String at index {stringIndex}: {stringArray[stringIndex]}");
        }
        else
        {
            Console.WriteLine("Index does not exist in the string array.");
        }

        int[] intArray = { 10, 20, 30, 40, 50 };
        Console.WriteLine("\nSelect an index of the integer array:");
        int intIndex = Convert.ToInt32(Console.ReadLine());

        if (intIndex >= 0 && intIndex < intArray.Length)
        {
            Console.WriteLine($"Integer at index {intIndex}: {intArray[intIndex]}");
        }
        else
        {
            Console.WriteLine("Index does not exist in the integer array.");
        }

        List<string> stringList = new List<string> { "tyrannosaurus", "triceratops", "ankylosaurus", "edmontosaurus", "pachycephalosaurus" };
        Console.WriteLine("\nSelect an index of the string list:");
        int listIndex = Convert.ToInt32(Console.ReadLine());

        if (listIndex >= 0 && listIndex < stringList.Count)
        {
            Console.WriteLine($"String at index {listIndex}: {stringList[listIndex]}");
        }
        else
        {
            Console.WriteLine("Index does not exist in the string list.");
        }
    }
}