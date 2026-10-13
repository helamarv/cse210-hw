using System;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }
        Console.WriteLine();
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("Select the type of goal to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            // Create a simple goal
            SimpleGoal simpleGoal = new SimpleGoal();
            simpleGoal.CreateChildGoal();
            _goals.Add(simpleGoal);
        }
        else if (choice == 2)
        {
            // Create an eternal goal
            EternalGoal eternalGoal = new EternalGoal();
            eternalGoal.CreateChildGoal();
            _goals.Add(eternalGoal);
        }
        else if (choice == 3)
        {
            // Create a checklist goal
            ChecklistGoal checklistGoal = new ChecklistGoal();
            checklistGoal.CreateChildGoal();
            _goals.Add(checklistGoal);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }

        return ;    
    }


    public void RecordEvent(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();

            int sum = 0;

            if (_goals[index] is EternalGoal)
            {
                sum += _goals[index].Points;
            }
            else if (_goals[index].IsComplete())
            {
                sum += _goals[index].Points;

                if (_goals[index] is ChecklistGoal checklistGoal)
                {
                    sum += checklistGoal.Bonus;
                }
            }

            _score += sum;

            if (sum > 0)
            {
                Console.WriteLine(
                    $"Congratulations! You have earned {sum} points."
                );
            }
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);

        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',');

            string[] firstPart = parts[0].Split(':');
            string goalType = firstPart[0];
            string shortName = firstPart[1];
            string description = parts[1];
            int points = int.Parse(parts[2]);

            if (goalType == "SimpleGoal")
            {
                bool isComplete = bool.Parse(parts[3]);

                SimpleGoal goal = new SimpleGoal(
                    shortName, description, points, isComplete);

                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(
                    shortName, description, points);

                _goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                int amountCompleated = int.Parse(parts[3]);
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);

                ChecklistGoal goal = new ChecklistGoal(
                    shortName, description, points,
                    target, bonus, amountCompleated);

                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully!");
    }}