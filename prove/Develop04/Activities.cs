using System;

public class Activity
{
    protected string name;
    protected string description;
    protected int duration;
    protected DateTime _startTime;
    protected DateTime _endTime;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    protected void DisplayWelcomeMessage()
    {
        Console.WriteLine($"Welcome to {name} activity!\n\n {description}");
        Console.Write("\nEnter the duration of the activity (in seconds): ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            this.duration = duration;
            Console.Write("Get ready...");
            for (int index = 5; index > 0; index--)
            {
                Console.Write(index);
                System.Threading.Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }

    protected void DisplayCompletionMessage()
    {
        Console.WriteLine($"You have completed {name} for {duration} seconds. Well done.");
        for (int index = 5; index > 0; index--)
        {
            Console.Write(index);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b");
        }
    }
}
