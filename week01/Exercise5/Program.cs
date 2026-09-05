using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        static void DisplayWelcome ()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName ()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
            // Console.WriteLine($"Hello, {name}!");
        }
        static int PromptUserNumber ()
        {
            Console.Write("Please enter your favorite number: ");
            string inputString = Console.ReadLine();
            int number = int.Parse(inputString);
            return number;
        }

        static int SquareNumber (int number)
        {
            return number * number;
        }

        static void DisplayResult (int squaredNumber, string name)
        {
            Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
        }


        DisplayWelcome();
        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);
        DisplayResult(squaredNumber, name);

    }
}