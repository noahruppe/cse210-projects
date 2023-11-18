using System;
using System.Collections.Generic;
using System.IO;

public class Goals 
{
    protected int _totalpoints = 0;
    private string _goalname = "";
    private string _goaldescription = "";
    protected int  _goalpoints = 0;
    protected bool isComplete = false;
    private int checklistCount = 0;  // Added for checklist goals

    public List<Goals> GoalsList { get; private set; }

    public Goals(int totalpoints, string goalname, string goaldescription, int goalpoints)
    {
        _totalpoints = totalpoints;
        _goalname = goalname;
        _goaldescription = goaldescription;
        _goalpoints = goalpoints;
        GoalsList = new List<Goals>();
    }

    public int GetTotalPoints()
    {
        return _totalpoints;
    }

    public void SetTotalPoints(int totalpoints)
    {
        _totalpoints = totalpoints;
    }

    public string GetGoalName()
    {
        return _goalname;
    }

    public void SetGoalName(string goalname)
    {
        _goalname = goalname;
    }

    public string GetGoalDescription()
    {
        return _goaldescription;
    }

    public void SetGoalDescription(string goaldescription)
    {
        _goaldescription = goaldescription;
    }

    public int GetGoalPoints()
    {
        return _goalpoints;
    }

    public void SetGoalPoints(int goalpoints)
    {
        _goalpoints = goalpoints;
    }

    public bool IsComplete()
    {
        return isComplete;
    }

    public void MarkComplete()
    {
        isComplete = true;
    }

    public virtual void AddItemToList(Goals item)
    {
        GoalsList.Add(item);
    }

    public virtual string DisplayInfo()
    {
        string completionStatus = isComplete ? "[X]" : "[ ]";
        string pointsInfo = $" ({GetTotalPoints()})";
        string completionInfo = isComplete ? $" Completed {checklistCount}/{checklistCount} times." : "";

        if (this is CheckListGoals checklistGoal)
        {
            return $"{completionStatus} Goal: {GetGoalName()} - ({GetGoalDescription()}){completionInfo}\n\nYou have {pointsInfo} points";
        }
        else if (this is EternalGoals eternalGoals)
        {
            return $"{completionStatus} Goal: {GetGoalName()} - ({GetGoalDescription()})\n\nYou have {pointsInfo} points";
        }
        else if (this is SimpleGoals simpleGoals)
        {
            return $"{completionStatus} Goal: {GetGoalName()} - ({GetGoalDescription()}){pointsInfo}";
        }
        else
        {
            return $"{completionStatus} Goal: {GetGoalName()} - ({GetGoalDescription()}){pointsInfo}";
        }
    }

    public virtual void RecordEvent()
    {
        if (!isComplete)
        {
            _totalpoints += _goalpoints;
            Console.WriteLine($"Event recorded for {GetGoalName()}! You earned {_goalpoints} points.");
            if (checklistCount > 0 && checklistCount % 5 == 0)
            {
                _totalpoints += 500;  // Bonus for completing a checklist goal
                Console.WriteLine($"Bonus: You achieved the checklist goal! You earned 500 bonus points.");
            }
            checklistCount++;  // Increment the checklist count
            MarkComplete();  // Mark the goal as complete
        }
        else
        {
            Console.WriteLine($"Event for {GetGoalName()} already recorded.");
        }
    }

    public void SaveGoals(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Goals goal in GoalsList)
            {
                writer.WriteLine($"{goal.GetTotalPoints()}|{goal.GetGoalName()}|{goal.GetGoalDescription()}|{goal.GetGoalPoints()}|{goal.IsComplete()}|{goal.checklistCount}");
            }
        }
    }

    public void LoadGoals(string fileName)
    {
        if (File.Exists(fileName))
        {
            GoalsList.Clear();

            foreach (string line in File.ReadLines(fileName))
            {
                string[] parts = line.Split('|');
                if (parts.Length >= 6)
                {
                    int totalpoints;
                    if (int.TryParse(parts[0], out totalpoints))
                    {
                        string goalname = parts[1];
                        string goaldescription = parts[2];
                        int goalpoints;
                        if (int.TryParse(parts[3], out goalpoints))
                        {
                            bool isComplete;
                            if (bool.TryParse(parts[4], out isComplete))
                            {
                                int checklistCount;
                                if (int.TryParse(parts[5], out checklistCount))
                                {
                                    Goals loadedGoal = new Goals(totalpoints, goalname, goaldescription, goalpoints)
                                    {
                                        isComplete = isComplete,
                                        checklistCount = checklistCount
                                    };
                                    GoalsList.Add(loadedGoal);
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("The specified file does not exist.");
        }
    }
}



