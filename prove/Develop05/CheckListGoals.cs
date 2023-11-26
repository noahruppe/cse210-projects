using System;
using System.Runtime.CompilerServices;

public class ChecklistGoal : Goal
{
    protected int _amountOFTimes;
    protected int _bonusPoints;
    private int _completedTimes = 0;

    public ChecklistGoal(string goalname, string goaldescription, int amount, int amountOFTimes, int bonusPoints)
        : base(goalname, goaldescription, amount)
    {
        _amountOFTimes = amountOFTimes;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        int points = base.RecordEvent();

        if (!isComplete)
        {
            _completedTimes++;

            if (_completedTimes == _amountOFTimes)
            {
                isComplete = true;
            }
        }

        return points;
    }
    public override string ToString()
    {
        string status = isComplete ? "[X]" : "[ ]";
        string progress = $"(currently completed ({_completedTimes}/{_amountOFTimes}))";
        return $"{status} Goal: {_goalName} - ({_goalDescription}) {progress}";
    }
    


    


}
