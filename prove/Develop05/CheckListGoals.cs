using System;

public class CheckListGoals : Goals
{
    public int desiredCompletions;
    public int completionsCount;  // Change the access modifier to protected
    private int bonusPoints;

    public CheckListGoals(int totalpoints, string goalname, string goaldescription, int goalpoints, int desiredCompletions, int bonusPoints)
        : base(totalpoints, goalname, goaldescription, goalpoints)
    {
        this.desiredCompletions = desiredCompletions;
        this.completionsCount = 0;
        this.bonusPoints = bonusPoints;
    }

   public override void RecordEvent()
{
    if (completionsCount < desiredCompletions)
    {
        _totalpoints += GetGoalPoints();  // Include points for completing the goal
        completionsCount++;

        Console.WriteLine($"Event recorded for {GetGoalName()}! You earned {_goalpoints} points.");

        if (completionsCount == desiredCompletions)
        {
            isComplete = true;  // Mark the goal as complete when the desired completions are reached
            _totalpoints += bonusPoints; // Bonus for completing the checklist goal
            Console.WriteLine($"Bonus: You achieved the checklist goal! You earned {bonusPoints} bonus points.");
        }
    }
    else
    {
        Console.WriteLine($"Checklist goal {GetGoalName()} has already been completed {desiredCompletions} times.");
    }
}
    public override string DisplayInfo()
    {
        string completionStatus = isComplete ? "[X]" : "[ ]";
        string pointsInfo = $" ({GetTotalPoints()})";

        if (this is CheckListGoals checklistGoal)
        {
            if (completionsCount < desiredCompletions)
            {
                return $"{completionStatus} Goal: {GetGoalName()} - ({GetGoalDescription()}){pointsInfo}";
            }
            else if (completionsCount == desiredCompletions)
            {
                return $"{completionStatus} Goal: {GetGoalName()} - ({GetGoalDescription()}) Completed {completionsCount}/{desiredCompletions} times. {pointsInfo}";
            }
        }

        // Default return for other goal types
        return $"{completionStatus} Goal: {GetGoalName()} - ({GetGoalDescription()}){pointsInfo}";
    }

    public void DisplayProgress()
    {
        Console.WriteLine($"Progress for {GetGoalName()}: Completed {completionsCount}/{desiredCompletions} times.");
    }

    public static CheckListGoals CreateCheckListGoal()
    {
        Console.Write("What is the name of your checklist goal? ");
        string goalname = Console.ReadLine();

        Console.Write("Give a short description of the checklist goal. ");
        string goaldescription = Console.ReadLine();

        Console.Write("What is the amount of points you want for doing this checklist goal each time? ");
        int goalpoints = int.Parse(Console.ReadLine());

        Console.Write("How many times do you want to complete this checklist goal to consider it finished? ");
        int desiredCompletions = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus points you want for achieving the checklist goal? ");
        int bonusPoints = int.Parse(Console.ReadLine());

        // Pass totalpoints to the base class constructor
        return new CheckListGoals(goalpoints, goalname, goaldescription, goalpoints, desiredCompletions, bonusPoints);
    }

    // Add a public property to access completionsCount
    public int CompletionsCount
    {
        get { return completionsCount; }
    }
    
}




