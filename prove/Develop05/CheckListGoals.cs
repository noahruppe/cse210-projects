using System;

public class ChecklistGoals : Goals
{
    protected int _amountOFTimes;
    protected int _bonusPoints;
    private int _completedTimes = 0;

    public ChecklistGoals(int Totalpoints, string goalname, string goaldescription, int amount, int amountOFTimes, int bonusPoints)
        : base(Totalpoints, goalname, goaldescription, amount)
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();

        Console.Write("Give a small description of the goal. ");
        _goalDescription = Console.ReadLine();

        Console.Write("what is the worth of doing this goal? ");
        string result = Console.ReadLine();
        _amount = int.Parse(result);

        Console.Write("how many times do you want to do this to get the bonus points? ");
        string result1 = Console.ReadLine();
        _amountOFTimes = int.Parse(result1);

        Console.Write("If you complete the amount of times specified how many points do you want? ");
        string result2 = Console.ReadLine();
        _bonusPoints = int.Parse(result2);

        base.AddGoalToList(this);
    }

    public int AmountOFTimes
    {
        get { return _amountOFTimes; }
        set { _amountOFTimes = value; }
    }

    public int BonusPoints
    {
        get { return _bonusPoints; }
        set { _bonusPoints = value; }
    }

    public int CompletedTimes
    {
        get { return _completedTimes; }
        set { _completedTimes = value; }
    }

    public override void RecordEvent()
    {
        if (!isComplete)
        {
            AccumulatePoints(_amount);

            RecordCompletion();

            if (ChecklistGoalCompleted())
            {
                AccumulatePoints(_bonusPoints);
            }
        }
        MarkComplete();
    }

    private void RecordCompletion()
    {
        _completedTimes++;
    }

    private bool ChecklistGoalCompleted()
    {
        return _completedTimes >= _amountOFTimes;
    }

    public override void GetStatus()
    {
        string status = ChecklistGoalCompleted() ? "[X]" : "[ ]";
        Console.WriteLine($"{status} Goal: {_goalName} - ({_goalDescription}) --- (Currently completed {_completedTimes}/{_amountOFTimes})");
    }
}
