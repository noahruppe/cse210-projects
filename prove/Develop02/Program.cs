using System;

class Program
{
    static void Main(string[] args)
    {
        Prompts Prompt1 = new Prompts();
        Prompt1._interestingPerson = "Who was the most interesting person I interacted with today?";
        Prompt1._bestPartOfDay = "What was the best part of my day?";
        Prompt1._lordsHand = "How did I see the hand of the Lord in my life today?";
        Prompt1._emotionFelt = "What was the strongest emotion I felt today?";
        Prompt1._doOver = "If I had one thing I could do over today, what would it be?";

        Randomizer randomizer = new Randomizer();
        randomizer.AddPrompt(Prompt1);

        Console.WriteLine("Prompt:");
        randomizer.DisplayRandomPrompt();

    }
}

