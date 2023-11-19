using System;
using System.ComponentModel;


public class SimpleGoals : Goals
{





    public SimpleGoals(int Totalpoints,string goalname,string goaldescription,int amount):base(Totalpoints,goalname,goaldescription,amount)
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        

        Console.Write("Give a small description of the goal. ");
        _goalDescription = Console.ReadLine();

        Console.Write("what is the worth of doing this goal? ");
         string result = Console.ReadLine();
         _amount = int.Parse(result);

         base.AddGoalToList(this);
        
    }
}