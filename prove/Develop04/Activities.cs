using System;
using System.Collections.Generic;
using System.Threading;

public class Activities
{
    private string _startmsg = "";
    private string _endmsg = "";
    private int _timer = 0;

    public Activities(string start, string end )
    {
        _startmsg = start;
        _endmsg = end;
    }

    public string GetStart()
    {
        return _startmsg;
    }

    public void SetStart(string start)
    {
        _startmsg = start;
    }

    public string GetEnd()
    {
        return _endmsg;
    }

    public void SetEnd(string end)
    {
        _endmsg = end;
    }

    public string GetStartDisplayMsg()
    {
        return GetStart();
    }

    public string GetEndDisplayMsg()
    {
        return GetEnd();
    }

    public int GetTimer()
    {
        return _timer;
    }

    public void SetTimer(int time)
    {
        _timer = time;
    }

    public void RunActivityWithTimer(int activityTime, Action activityAction)
    {
        Console.WriteLine("Get ready...");
        for (int index = 5; index > 0; index--)
        {
            Console.Write(index);
            Thread.Sleep(1000);
            Console.Write("\b");
        }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(activityTime);

        while (DateTime.Now < endTime)
        {
            activityAction();
        }
    }
}
