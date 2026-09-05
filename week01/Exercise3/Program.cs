using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int magicNumberInt = randomGenerator.Next(1, 101);

        /*
        Console.Write("What is the magic number? ");
        string magicNumber = Console.ReadLine();
        int magicNumberInt = int.Parse(magicNumber);
        */

        int tries = 0;
        int guessInt = 0;
        while (guessInt != magicNumberInt)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guessInt = int.Parse(guess);
            tries++;

            if (guessInt < magicNumberInt)
            {
                Console.WriteLine("Your guess is too low.");
            }
            else if (guessInt > magicNumberInt)
            {
                Console.WriteLine("Your guess is too high.");
            }
        }
        Console.WriteLine($"Congratulations! You guessed the magic number in {tries} tries.");

    }
}