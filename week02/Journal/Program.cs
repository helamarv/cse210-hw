using System;
// For exceedign the requirements, I added the ability to save and load the journal in CSV format.
class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a text file");
            Console.WriteLine("4. Load the journal from a text file");
            Console.WriteLine("5. Save the journal to a csv file");
            Console.WriteLine("6. Load the journal from a csv file");
            Console.WriteLine("7. Quit");

            Console.Write("Enter your choice (1-7): ");
            string choice = Console.ReadLine();

            Console.WriteLine("");

            switch (choice)
            {
                case "1":
                    PromptGenerator promptGenerator = new PromptGenerator();
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    Entry entry = new Entry
                    {
                        _date = DateTime.Now.ToString("yyyy-MM-dd"),
                        _promptText = prompt,
                        _entryText = response
                    };
                    journal.AddEntry(entry);
                    Console.WriteLine("Entry added successfully.");
                    Console.WriteLine("");
                    break;

                case "2":
                    Console.WriteLine("");
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile($"{saveFilename}.txt");
                    Console.WriteLine("Journal saved successfully.");
                    Console.WriteLine("");
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile($"{loadFilename}.txt");
                    Console.WriteLine("Journal loaded successfully.");
                    Console.WriteLine("");
                    break;

                case "5":
                    Console.Write("Enter filename to save: ");
                    string saveCsvFilename = Console.ReadLine();
                    journal.SaveToCsv($"{saveCsvFilename}.csv");
                    Console.WriteLine("Journal saved to CSV successfully.");
                    Console.WriteLine("");
                    break;

                case "6":
                    Console.Write("Enter filename to load: ");
                    string loadCsvFilename = Console.ReadLine();
                    journal.LoadFromCsv($"{loadCsvFilename}.csv");
                    Console.WriteLine("Journal loaded from CSV successfully.");
                    Console.WriteLine("");
                    break;

                case "7":
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}