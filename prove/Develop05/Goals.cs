using System;
using System.Xml.Schema;
using System.Collections.Generic;


public class Goal
{
    protected string _goalName;

    protected string _goalDescription;

    protected int _amount;

    protected bool isComplete;







    public Goal(string goalname, string goaldescription, int amount)
    {
        _goalName = goalname;
        _goalDescription = goaldescription;
        _amount = amount;

    }
    public virtual int RecordEvent()
    {
        if (!isComplete)
        {
            return _amount;
        }
        else
        {
            return 0;
        }
    }
    public override string ToString()
    {
        string status = isComplete ? "[X]" : "[ ]";
        return $"{status} Goal: {_goalName} - ({_goalDescription})";
    }
    public virtual string TOSaveString()
    {
        string status = isComplete ? "1" : "0";
        return $"{GetType().Name}|{_goalName}|{_goalDescription}|{_amount}|{status}";
    }
    

    
}
    


