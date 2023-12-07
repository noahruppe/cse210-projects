using System;
using System.Collections.Generic;


public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int length, double speed) : base(date, length)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Speed: {speed} kph, Pace: {GetPace():F2} min/km";
    }
}