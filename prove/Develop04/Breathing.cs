using System;


public class Breathing:Activities
{
    public Breathing(string start, string end) : base (start,end)
    {
        
    }
     public void DisplayBreathing()
    {
        for (int i = 3; i > 0; i--)
        {
            Console.Write($"Breath in... {i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write($"Breath out... {i} ");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
}   }