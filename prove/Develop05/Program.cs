using System;
using System.Runtime.Serialization;


class Program
{
    static void Main(string[] args)
    {
        Goals goals =new Goals(0,"","",0);
        bool continuegame = true;
        while(continuegame)
        {
            Console.WriteLine("Menu options");
            Console.WriteLine("1. Create a goal");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Which option would you like to choose ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Which goal would you like to do?");
                Console.WriteLine("1. Simple Goal: ");
                Console.WriteLine("2. Eternal Goal: ");
                Console.WriteLine("3. Checklist Goal: ");
                Console.Write("Which goal would you like to do? ");
                string choice2 = Console.ReadLine();

                if (choice2 == "1")
                {
                    SimpleGoals simpleGoals = new SimpleGoals(0,"","",0);
                    goals.AddGoalToList(simpleGoals);
                    
                }
                else if  (choice2 == "2")
                {

                }
                else if (choice2 == "3")
                {

                }

            }
            else if (choice == "2")
            {
                goals.DisplayGoalsList();

            }
            else if (choice == "3")
            {
               goals.SaveOption("goals.txt");
            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename to load goals from: ");
                string fileName = Console.ReadLine();
                goals.LoadOption(fileName);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Select a goal to record an event:");

                for (int i = 0; i < goals.GoalsList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goals.GoalsList[i].GetGoalName()}");
                }

                Console.Write("Enter the index of the goal you completed: ");

                if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex >= 1 && goalIndex <= goals.GoalsList.Count)
                {
                    goals.RecordEventAtIndex(goalIndex - 1);
                }
            }
            else if (choice == "6")
            {
                continuegame = false;
            }

        }
    }
}

