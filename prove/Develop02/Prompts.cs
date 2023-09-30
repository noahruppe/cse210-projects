using System;

public class Prompts
{
    public string _interestingPerson;

    public string _bestPartOfDay;

    public string _lordsHand;

    public string _emotionFelt;

    public string _doOver;

    public void Display()
    {
        Console.WriteLine($"Who was the most interesting person I interacted with today? {_interestingPerson}");
        Console.WriteLine($"What was the best part of my day? {_bestPartOfDay}");
        Console.WriteLine($"How did I see the hand of the Lord in my life today? {_lordsHand}");
        Console.WriteLine($"What was the strongest emotion I felt today? {_emotionFelt}");
        Console.WriteLine($"If I had one thing I could do over today, what would it be? {_doOver}");
    }
}

