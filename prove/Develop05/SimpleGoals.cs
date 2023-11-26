using System;
using System.ComponentModel;
using System.Xml.Linq;


public class SimpleGoal : Goal
{





    public SimpleGoal(string goalname,string goaldescription,int amount):base(goalname,goaldescription,amount)
    {
        
    }
    public override int RecordEvent()
    {
        int points = base.RecordEvent();
        isComplete = true; 
        return points;
    }
    

}

