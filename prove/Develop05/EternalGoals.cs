using System;

public class EternalGoals : Goals
{
    public EternalGoals(int totalpoints) : base(totalpoints, "", "", 0)
    {
        Console.Write("What is the name of your eternal goal? ");
        string goalname = Console.ReadLine();
        SetGoalName(goalname);

        Console.Write("Give a short description of the eternal goal. ");
        string goaldescription = Console.ReadLine();
        SetGoalDescription(goaldescription);

        Console.Write("What is the amount of points you want for doing this eternal goal each time? ");
        string goalpoints = Console.ReadLine();
        int result = int.Parse(goalpoints);
        SetGoalPoints(result);
    }

    public override void RecordEvent()
    {
        if (!isComplete)
        {
        _totalpoints += GetGoalPoints();
        Console.WriteLine($"Event recorded for {GetGoalName()}! You earned {_goalpoints} points.");
        }
    }
}


