using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager goalManager = new GoalManager();

        // int choice = int.Parse(Console.ReadLine());
        int choice = 0;
        while (choice != 6)
        {
            goalManager.DisplayPlayerInfo();
            goalManager.Start();
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                goalManager.CreateGoal();
            }
            else if (choice == 2)
            {
                goalManager.ListGoalNames();
            }
            else if (choice == 3)
            {
                goalManager.SaveGoals();
            }
            else if (choice == 4)
            {
                goalManager.LoadGoals();
            }
            else if (choice == 5)
            {
                goalManager.ListGoalNames();
                Console.Write("Enter the number of the goal to record an event: ");
                int index = int.Parse(Console.ReadLine()) - 1;
                goalManager.RecordEvent(index);
                Console.WriteLine("Event recorded successfully!");
            }
            else if (choice == 6)
            {
                Console.WriteLine("Thank you for playing EternalQuest!");
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

    }
}