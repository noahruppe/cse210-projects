using System;
using System.Collections.Generic;


public class SimpleGoals : Goals
{
    public SimpleGoals(int totalpoints) : base(totalpoints, "", "", 0)
    {
        Console.Write("What is the name of your goal? ");
        string goalname = Console.ReadLine();
        SetGoalName(goalname);

        Console.Write("Give a short description of the goal. ");
        string goaldescription = Console.ReadLine();
        SetGoalDescription(goaldescription);

        Console.Write("What is the amount of points you want for doing this goal? ");
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
        MarkComplete();  // Mark the goal as complete
        }
    }

    public override string DisplayInfo()
{
    string completionStatus = isComplete ? "[X]" : "[ ]";
    string pointsInfo = $" ({GetTotalPoints()})";

    return $"{completionStatus} Goal: {GetGoalName()} - ({GetGoalDescription()}){pointsInfo}";
}
}


