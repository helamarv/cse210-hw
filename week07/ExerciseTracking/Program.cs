using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        // Create instances of each activity
        Running runningActivity = new Running(new DateTime(2022, 10, 3), 30, 4.8);
        Cycling cyclingActivity = new Cycling(DateTime.Now, 45, 15.0);
        Swimming swimmingActivity = new Swimming(DateTime.Now, 60, 20.0);

        // Display summaries for each activity
        Console.WriteLine(runningActivity.GetSummary());
        Console.WriteLine(cyclingActivity.GetSummary());
        Console.WriteLine(swimmingActivity.GetSummary());
    }
}