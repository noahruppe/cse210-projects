using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options");
        Console.WriteLine("1: Start Breathing Activity");
        Console.WriteLine("2: Start Reflection Activity");
        Console.WriteLine("3: Start List Activity");
        Console.WriteLine("4: Quit");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Breathing breathing = new Breathing();
                breathing.DisplayBreathing();
                break;

            case "2":
                Reflection reflection = new Reflection();
                reflection.StartQuotes();
                reflection.AddQuestions();
                reflection.StartReflection();
                break;

            case "3":
                ListActivity listActivity = new ListActivity();
                listActivity.StartPrompts();
                listActivity.StartList();
                break;

            case "4":
                Console.WriteLine("Goodbye!");
                break;

            default:
                Console.WriteLine("Invalid choice. Please select a valid option.");
                break;
        }
    }
}
