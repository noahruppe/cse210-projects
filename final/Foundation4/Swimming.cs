using System;

public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        
        return laps * 50 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / length * 60;
    }

    public override double GetPace()
    {
        
        if (GetDistance() > 0)
        {
            return length / GetDistance();
        }
        else
        {
            return 0;
        }
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Number of laps: {laps}, Distance: {GetDistance()} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min/mile";
    }
}
