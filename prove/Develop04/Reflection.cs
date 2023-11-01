using System;
using System.Collections.Generic;
using System.Threading;

public class Reflection : Activity
{
    private List<string> _prompts;
    private List<string> _ponder;
    private HashSet<string> _askedQuestions;

    public Reflection() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>();
        _ponder = new List<string>();
        _askedQuestions = new HashSet<string>();
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

    public void StartReflection()
    {
        DisplayWelcomeMessage();

        Console.WriteLine("\nStarting the reflection activity...");

        Random random = new Random();
        _endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < _endTime)
        {
            string question = GetRandomQuestion();
            
            if (_askedQuestions.Add(question)) // this is what I did for extra credit I made it to where the question does not repeat itself*//
            {
                Console.WriteLine($"\n\n---{question}---");
                
                Console.WriteLine("\nGet ready...");
                for (int index = 10; index > 0; index--)
                {
                    Console.Write(index);
                    Thread.Sleep(1000);
                    Console.Write("\r ");
                }
            }
        }

        Console.WriteLine("Reflection activity completed.");
        DisplayCompletionMessage();
    }

    public string GetRandomQuestion()
    {
        if (_ponder.Count > 0)
        {
            Random random = new Random();
            int index = random.Next(_ponder.Count);
            string question = _ponder[index];
            _ponder.RemoveAt(index);
            return question;
        }
        else
        {
            return "no question";
        }
    }
}
