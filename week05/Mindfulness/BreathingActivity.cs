
using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetActivityDetails(
            "Breathing Activity",
            "This activity will help you relax by walking you through " +
            "breathing in and out slowly. Clear your mind and focus on " +
            "your breathing.");
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        bool breatheIn = true;

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(
                breatheIn ? "Breathe in..." : "Breathe out...");

            int remaining = (int)Math.Ceiling(
                (endTime - DateTime.Now).TotalSeconds);

            ShowCountDown(Math.Min(4, remaining));

            breatheIn = !breatheIn;
        }

        DisplayEndingMessage();
    }
}