using System;


public class Activities
{
   private string _startmsg = "";

   private string _endmsg = "";

   private int _timer = 0;


    public Activities(string start ,string end)
    {
        _startmsg = start;
        _endmsg = end;
    }
   public string GetStart()
   {
    return _startmsg;
   }
   public void Setstart(string start)
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
   public void GetTimerInfo()
   {
    Console.WriteLine("please enter the amount of seconds you want for this activity");
    string  UserInput = Console.ReadLine();

    int number = int.Parse(UserInput);

    _timer = number;

    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(_timer);


    while (DateTime.Now < futureTime)
    {
        Thread.Sleep(1000);
    }
   }
}

