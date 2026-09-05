using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int input = -1;
        int sum = 0;
        int count = 0;

        while (input != 0)
        {
            Console.Write("Enter a number: ");
            string inputString = Console.ReadLine();
            input = int.Parse(inputString);
            if (input != 0)
            {
                numbers.Add(input);
                sum += input;
                count++;
            }
        }
        // SUM
        Console.WriteLine($"\nThe sum of the numbers is: {sum}");

        // AVERAGE
        Console.WriteLine($"The average of the numbers is: {sum / (double)count}");

        // BIGGEST
        int biggest = numbers.Max();
        Console.WriteLine($"The biggest number is: {biggest}");

        // SMALLEST
        int smallestPositive = numbers
        .Where(n => n > 0)
        .Min();
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // SORTED NUMBERS
        numbers.Sort();
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}