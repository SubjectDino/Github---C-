using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> stringList = new List<string>()
        {
            "apple",
            "banana",
            "orange",
            "apple",
            "grape",
            "orange"
        };

        HashSet<string> seenStrings = new HashSet<string>();

        foreach (string str in stringList)
        {
            if (seenStrings.Contains(str))
            {
                Console.WriteLine($"'{str}' has already appeared in the list.");
            }
            else
            {
                Console.WriteLine($"'{str}' has not appeared in the list before.");
                seenStrings.Add(str);
            }
        }
    }
}
Exp