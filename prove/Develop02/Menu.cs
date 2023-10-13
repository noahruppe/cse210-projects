using System;

public class Menu
{
    private Journal journal;
    private bool isRunning;

    public Menu(Journal journal)
    {
        this.journal = journal;
        this.isRunning = true;
    }

    public void Run()
    {
        while (isRunning)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    WriteEntry();
                    break;
                case "2":
                    DisplayEntry();
                    break;
                case "3":
                    LoadEntries();
                    break;
                case "4":
                    SaveEntries();
                    break;
                case "5":
                    Quit();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }

    private void WriteEntry()
    {
        Entry entry = new Entry();
        entry.GetPromptFromUser(); 
        entry.Response = entry.GetResponseForPrompt(entry.Prompt);
        journal.AddEntry(entry);
        Console.WriteLine("Entry written successfully.");
    }

    private void DisplayEntry()
    {
        if (journal.Entries.Count > 0)
        {
            journal.DisplayEntries();
        }
        else
        {
            Console.WriteLine("No entries to display.");
        }
    }

    private void LoadEntries()
    {
        Console.Write("Enter a file name to load entries from: ");
        string fileName = Console.ReadLine();
        journal.LoadEntries(fileName);
        Console.WriteLine("Entries loaded successfully.");
    }

    private void SaveEntries()
    {
        Console.Write("Enter a file name to save entries: ");
        string fileName = Console.ReadLine();
        journal.SaveEntries(fileName);
        Console.WriteLine("Entries saved successfully.");
    }

    private void Quit()
    {
        isRunning = false;
    }
}
