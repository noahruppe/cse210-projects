using System;
using System.Xml.Schema;
using System.Collections.Generic;



public class Goals
{
    protected int _yourTotalPoints;

    protected string _goalName;

    protected string _goalDescription;

    protected int _amount;

    protected bool isComplete;

    protected int _accumulatedPoints;



    public List<Goals> GoalsList;


    public Goals(int  Totalpoints,string  goalname,  string goaldescription, int amount)
    {
        _yourTotalPoints = Totalpoints;
        _goalName = goalname;
        _goalDescription = goaldescription;
        _amount = amount;
        GoalsList = new List<Goals>();

    }

    public int GetTotalPoints()
    {
        return _yourTotalPoints;
    }
    public void SetTotalPoints(int totalpoints)
    {
        _yourTotalPoints = totalpoints;
    }
    public string GetGoalName()
    {
        return _goalName;
    }
    public void SetGoalName(string goalname)
    {
        _goalName = goalname;
    }
    public string GetGoalDescription()
    {
        return _goalDescription;
    }
    public void SetGoalDescription(string goaldescription)
    {
        _goalDescription = goaldescription;
    }
    public int GetAmount()
    {
        return _amount;
    }
    public void SetAmount(int amount)
    {
        _amount = amount;
    }
    public int GetAccumulatedPoints()
    {
        return _accumulatedPoints;
    }

    public void AccumulatePoints(int amount)
    {
        _accumulatedPoints += amount;
    }
    public bool GetIsComplete()
    {
        return isComplete;
    }
    public virtual void MarkComplete()
    {
        isComplete = true;
    }
    public void AddGoalToList(Goals goal)
    {
        GoalsList.Add(goal);
    }
    public virtual void RecordEvent()
    {
        if (!isComplete)
        {
            AccumulatePoints(_amount);
        }
        MarkComplete();
        }
    
     public void RecordEventAtIndex(int index)
    {
        if (index >= 0 && index < GoalsList.Count)
        {
            GoalsList[index].RecordEvent();
        }
    }
    public virtual  void GetStatus()
    {
        string status = isComplete && !(this is EternalGoals) ? "[X]" : "[ ]";
        Console.WriteLine($"{status} Goal: {_goalName} - {_goalDescription}");
    }
    public void DisplayGoalsList()
    {
        foreach (var goal in GoalsList)
        {
            goal.GetStatus();
        }

        int totalPoints = GoalsList.Where(goal => goal.GetIsComplete()).Sum(goal => goal.GetAmount());
        Console.WriteLine($"You have {totalPoints} ");
    }
    public void SaveOption(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var goal in GoalsList)
                {
                    writer.WriteLine($"{goal.GetTotalPoints()}|{goal.GetGoalName()}|{goal.GetGoalDescription()}|{goal.GetAmount()}|{goal.GetIsComplete()}");
                }
                Console.WriteLine($"You have {_yourTotalPoints} ");
            }
    }
    public void LoadOption(string fileName)
    {
        GoalsList.Clear(); // Clear existing goals before loading new ones

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length != 5)
                {
                    Console.WriteLine($"Invalid representation format: {line}");
                    continue;
                }

                int totalPoints = int.Parse(parts[0]);
                string goalName = parts[1];
                string goalDescription = parts[2];
                int amount = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);

                Goals goal = new Goals(totalPoints, goalName, goalDescription, amount);
                GoalsList.Add(goal);
                }
            }
    }
    
    




}