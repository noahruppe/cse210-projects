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
        // Distance in miles using the provided formula
        return laps * 50 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / length * 60;
    }

    public override double GetPace()
    {
        // Handle the case where distance is zero
        if (GetDistance() > 0)
        {
            return length / GetDistance();
        }
        else
        {
            return 0; // or any other appropriate value
        }
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Number of laps: {laps}, Distance: {GetDistance()} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min/mile";
    }
}
