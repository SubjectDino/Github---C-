using System;

class Program
{
    static void Main()
    {
        // Start of the program
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");

        // Asking questions and storing responses
        Console.Write("What is your name? ");
        string studentName = Console.ReadLine();

        Console.Write("What course are you on? ");
        string courseName = Console.ReadLine();

        Console.Write("What's the page number? ");
        int pageNumber = int.Parse(Console.ReadLine());

        Console.Write("Do you need assistance? Please answer 'true' or 'false': ");
        bool needsHelp = bool.Parse(Console.ReadLine());

        Console.Write("Were there any positive experiences you'd like to share? With specifics: ");
        string positiveExperiences = Console.ReadLine();

        Console.Write("Is there any other feedback you'd like to provide? Be specific: ");
        string additionalFeedback = Console.ReadLine();

        Console.Write("How many hours did you study today? ");
        double studyHours = double.Parse(Console.ReadLine());

        // Printing thank you message
        Console.WriteLine("\nThank you for the answers, an Instructor will respond to this shortly.");

        // End of the program
    }
}