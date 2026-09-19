using System;
// Exceeding Requirements is the program keeps track of which words have been hidden and will not hide the same word again until all words have been hidden at least once.
class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths. The Lord is my shepherd, I lack nothing.");
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide more words or type 'exit' to quit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
            {
                break;
            }
            scripture.HideRandomWords();
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Press Enter to hide more words or type 'exit' to quit.");
        string input2 = Console.ReadLine();
    }
}