using System;
using System.Collections.Generic;
using System.Threading;

public class ListActivity : Activity
{
    private List<string> _prompts;
    private List<string> _userinput;

    public ListActivity() : base("List Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _userinput = new List<string>();
        _prompts = new List<string>();
    }

    public void StartPrompts()
    {
        string[] myprompts = GetPromptInfo();
        _prompts.AddRange(myprompts);
    }

    public string[] GetPromptInfo()
    {
        return new string[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes"
        };
    }

    public string GetRandomPrompt()
    {
        if (_prompts.Count > 0)
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            string prompt = _prompts[index];
            _prompts.RemoveAt(index);
            return prompt;
        }
        else
        {
            return "no prompt";
        }
    }

    public void StartList()
    {
        DisplayWelcomeMessage();

        Console.WriteLine("\n\nStarting the listing activity...");

        Random random = new Random();

        string randomizer = GetRandomPrompt();

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"\n---{randomizer}---\n");

        int activityTime = duration;
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(activityTime);

        while (_startTime < _endTime)
        {
            string input = Console.ReadLine();
            _userinput.Add(input);
            _startTime = DateTime.Now;
        }

        Console.WriteLine($"You entered {_userinput.Count} responses.");
        DisplayCompletionMessage();
    }
}
