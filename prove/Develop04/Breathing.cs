using System;
using System.Reflection.Metadata;
using System.Threading;

class Breathing : Activities
{
    private DateTime _starttime;
    private DateTime _endtime;
    public Breathing(string start, string end) : base(start, end)
    {
    }

    public void DisplayBreathing(int activityTime)
    {
        _starttime = DateTime.Now;
        _endtime = _starttime.AddSeconds(activityTime);

        Console.WriteLine("Get ready...");
        for (int index = 5; index > 0; index--)
        {
            Console.Write(index);
            Thread.Sleep(1000);
            Console.Write("\b");
        }

        while (DateTime.Now < _endtime)
        {
            for (int index = 4; index > 0; index--)
            {
                Console.Write($"Breath In...{index}  ");
                Thread.Sleep(1000);
                Console.Write("\r ");
            }

            for (int index = 4; index > 0; index--)
            {
                Console.Write($"Breath Out...{index}  ");
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

