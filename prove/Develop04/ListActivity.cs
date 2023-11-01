using System;
using System.Collections.Generic;
using System.Threading;

public class ListActivity : Activities
{
    private List<string> _prompts;
    private List<string> _userinput;
    private DateTime startTime;
    private DateTime endTime;

    public ListActivity(string start, string end) : base(start, end)
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
            return "no quote";
        }
    }
    public void StartList(int activityTime)
    {
        Console.WriteLine("Get ready...");
        for (int index = 5; index > 0; index--)
        {
            Console.Write(index);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        string[] userInputs = GetUserInput(activityTime);

        int entryCount = userInputs.Length ; 
        Console.WriteLine($"\nthe amount of entries was {entryCount}\n");

    }


    public string[] GetUserInput(int activityTime)
    {
        List<string> userInputs = new List<string>();

        startTime = DateTime.Now;
        endTime = startTime.AddSeconds(activityTime);


        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            userInputs.Add(input);
        }

        return userInputs.ToArray();
    }
    public void DisplayCompletionMessage(int activityTime)
    {
    Console.WriteLine($"You have completed another {activityTime} seconds of reflection.");
    }

}
