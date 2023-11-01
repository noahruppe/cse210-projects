using System;
using System.Threading;

public class Breathing : Activity
{
    public Breathing() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void DisplayBreathing()
    {
        DisplayWelcomeMessage();

        Console.Write("Starting the breathing exercise...\n");
        Thread.Sleep(2000);

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            for (int index = 4; index > 0; index--)
            {
                Console.Write(index);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.Write("\nBreathe out... ");
            for (int index = 4; index > 0; index--)
            {
                Console.Write(index);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        
    }
}
