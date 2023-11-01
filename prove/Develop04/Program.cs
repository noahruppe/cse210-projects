using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Activities activities = new Activities("hello", "bye");
        Console.WriteLine("Menu Options");
        Console.WriteLine("1: Start breathing activity");
        Console.WriteLine("2: Start reflecting activity");
        Console.WriteLine("3: Start listing activity");
        Console.WriteLine("4: Quit");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Breathing breathing = new Breathing("This activity will help you by walking you through breathing in and out slowly to help you calm your mind.", "Have a great day thank you for practicing breathing");
            string breathing1 = breathing.GetStartDisplayMsg();
            Console.WriteLine(breathing1);
            Console.WriteLine("Enter the duration of the breathing activity (in seconds):");
            if (int.TryParse(Console.ReadLine(), out int activityTime))
            {
                breathing.DisplayBreathing(activityTime);
                Console.WriteLine("Well done.\r");
                for (int index = 5; index > 0; index--)
                {
                    Console.Write(index);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                breathing.DisplayCompletionMessage(activityTime);
            }
        }
        else if (choice == "2")
        {
            Reflection reflection = new Reflection("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Good Bye, hopefully your reflection upon this day has brightened you today");
            string reflection1 = reflection.GetStartDisplayMsg();
            Console.WriteLine(reflection1);
            Console.WriteLine("Enter the duration of the reflection activity (in seconds):");
            if (int.TryParse(Console.ReadLine(), out int activityTime))
            {
                reflection.StartQuotes();
                string rando = reflection.GetRandomQuote();
                Console.WriteLine("\nGet ready...");
                for (int index = 5; index > 0; index--)
                {
                    Console.Write(index);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.WriteLine("Consider the following Prompt.\n");
                Console.WriteLine($"---{rando}---\n");
                Console.WriteLine("Press enter when you are ready to start");
                Console.ReadLine();
                reflection.AddQuestions();
                reflection.StartReflection(activityTime);
                string bye = reflection.GetEndDisplayMsg();
                Console.WriteLine(bye);
                Console.WriteLine("Well done.");
                for (int index = 5; index > 0; index--)
                {
                    Console.Write(index);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                reflection.DisplayCompletionMessage(activityTime);
            }
        }
        else if (choice == "3")
        {
            ListActivity listActivity = new ListActivity("\nWelcome to the listing activity\n\n this activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "hopefully you have seen how good your life is thank you for doing this activity.");
            string first = listActivity.GetStartDisplayMsg();
            Console.WriteLine(first);
            Console.Write("Enter the duration of the listing activity (in seconds):\n");
            if (int.TryParse(Console.ReadLine(), out int activityTime))
            {
                listActivity.StartPrompts();
                string randomizer = listActivity.GetRandomPrompt();
                Console.WriteLine("Get ready...");
                for (int index = 5; index > 0; index--)
                {
                    Console.Write(index);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.WriteLine("\nList as many responses as you can to the following prompts");
                Console.WriteLine($"---{randomizer}---");
                listActivity.StartList(activityTime);
                string goodbye = listActivity.GetEndDisplayMsg();
                Console.WriteLine($"{goodbye}\n");
                listActivity.DisplayCompletionMessage(activityTime);
            }
        }
    }
}
