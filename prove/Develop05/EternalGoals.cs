using System;

public class EternalGoal : Goal
{
    public EternalGoal(string goalname, string goaldescription, int amount)
        : base(goalname, goaldescription, amount)
    {
       
    }
    public override int RecordEvent()
    {
        int points = base.RecordEvent();
        return points;
    }
    public override string TOSaveString()
    {
        string saved = base.TOSaveString();
        return $"Eternal Goal: {saved}";
    }

}


