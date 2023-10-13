using System;
using System.Collections.Generic;

public class Entry
{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry()
    {
        Date = DateTime.Now;
    }

    public void GetPromptFromUser()
    {
        Console.WriteLine("Do you want to choose your own prompt? (yes/no)");
        string choice = Console.ReadLine();
        if (choice.ToLower() == "yes")
        {
            Console.Write("Enter your own prompt: ");
            Prompt = Console.ReadLine();
        }
        else
        {
            Prompt = GetRandomPrompt();
        }
    }

    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random random = new Random();
        int randomIndex = random.Next(prompts.Count);
        return prompts[randomIndex];
    }

    public string GetResponseForPrompt(string prompt)
    {
        Console.WriteLine(prompt);
        return Console.ReadLine();
    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}";
    }
}
