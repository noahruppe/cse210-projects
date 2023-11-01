using System;
using System.Collections.Generic;
using System.Threading;

public class Reflection : Activities
{
    private List<string> _prompts;
    private List<string> _ponder;
    private DateTime startTime;
    private DateTime endTime;

    public Reflection(string start, string end) : base(start, end)
    {
        _prompts = new List<string>();
        _ponder = new List<string>();
    }

    public void StartQuotes()
    {
        string[] myarray = GetQuotes();
        _prompts.AddRange(myarray);
    }

    public void AddQuestions()
    {
        string[] myquestions = GetPonderQuestion();
        _ponder.AddRange(myquestions);
    }

    public string[] GetQuotes()
    {
        return new string[]
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
    }

    public string[] GetPonderQuestion()
    {
        return new string[]
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public string GetRandomQuote()
    {
        if (_prompts.Count > 0)
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            return _prompts[index];
        }
        else
        {
            return "no quote";
        }
    }

    public string GetRandomQuestion()
    {
        if (_ponder.Count > 0)
        {
            Random random = new Random();
            int index = random.Next(_ponder.Count);
            string question = _ponder[index];
            /*this is what I have done for the show creativity part I have made it to where the randomizer will not repeat the same question*/
            _ponder.RemoveAt(index);
            return question;
        }
        else
        {
            return "no quote";
        }
    }

    public void StartReflection(int activityTime)
    {
        startTime = DateTime.Now;
        endTime = startTime.AddSeconds(activityTime);

        Console.WriteLine("Get ready...");
        for (int index = 5; index > 0; index--)
        {
            Console.Write(index);
            Thread.Sleep(1000);
            Console.Write("\b");
        }

        while (DateTime.Now < endTime)
        {
            string questions = GetRandomQuestion();
            Console.WriteLine(questions);
            Console.WriteLine("\nGet ready...");
            for (int index = 10; index > 0; index--)
            {
                Console.Write(index);
                Thread.Sleep(1000);
                Console.Write("\r ");
            }
        }
    }
    public void DisplayCompletionMessage(int activityTime)
    {
    Console.WriteLine($"You have completed another {activityTime} seconds of reflection.");
    }

}
