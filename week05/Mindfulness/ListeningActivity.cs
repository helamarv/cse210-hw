
using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private static readonly Random _random = new Random();

    public ListingActivity()
    {
        SetActivityDetails(
            "Listing Activity",
            "This activity will help you reflect on the good things " +
            "in your life by having you list as many things as you can " +
            "in a certain area.");

        _count = 0;

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();

        Console.WriteLine("You have a few seconds to think about the prompt.");
        ShowCountDown(5);

        Console.WriteLine();
        Console.WriteLine("Start listing items:");

        List<string> responses = GetListFromUser();

        _count = responses.Count;

        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write($"Item {responses.Count + 1}: ");

            string input = Console.ReadLine() ?? "";

            if (input.Trim().Equals(
                "done", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            if (!string.IsNullOrWhiteSpace(input))
            {
                responses.Add(input.Trim());
            }
        }

        return responses;
    }
}