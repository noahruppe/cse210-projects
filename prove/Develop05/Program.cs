using System;
using System.Runtime.Serialization;


class Program
{
    static void Main(string[] args)
    {
        List<Goal> goal = new List<Goal>();
        int totalPoints = 0;
        bool continuegame = true;
        while (continuegame)
        {
            Console.WriteLine($"You have: {totalPoints} points ");
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
                Console.Write("What is the name of your goal? ");

                string _goalName = Console.ReadLine();

                Console.Write("Give a small description of the goal. ");
                string _goalDescription = Console.ReadLine();

                Console.Write("what is the worth of doing this goal? ");
                string result = Console.ReadLine();
                int _amount = int.Parse(result);

                if (choice2 == "1")
                {
                    SimpleGoal simpleGoal = new SimpleGoal(_goalName, _goalDescription, _amount);
                    goal.Add(simpleGoal);

                }
                else if (choice2 == "2")
                {
                    EternalGoal eternalGoal = new EternalGoal(_goalName, _goalDescription, _amount);
                    goal.Add(eternalGoal);
                }
                else if (choice2 == "3")
                {
                    Console.Write("how many times do you want to do this to get the bonus points? ");
                    string result1 = Console.ReadLine();
                    int _amountOFTimes = int.Parse(result1);

                    Console.Write("If you complete the amount of times specified how many points do you want? ");
                    string result2 = Console.ReadLine();
                    int _bonusPoints = int.Parse(result2);

                    ChecklistGoal checklistGoal = new ChecklistGoal(_goalName, _goalDescription, _amount, _amountOFTimes, _bonusPoints);
                    goal.Add(checklistGoal);
                }

            }
            else if (choice == "2")
            {
                foreach (Goal goals in goal)
                {
                    Console.WriteLine(goals.ToString());
                }

            }
            else if (choice == "3")
            {
                // I added this for the extra credit that the user can save his goals to any file he wants so that he can keep his goals organized for each month if he wants
                Console.Write("Enter the filename to save the goals (or press Enter for default name): ");
                string filename = Console.ReadLine();
                if (string.IsNullOrEmpty(filename))
                {
                    filename = "goals.txt";
                }

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename))
                {
                    foreach (Goal g in goal)
                    {
                        file.WriteLine(g.TOSaveString());
                    }
                }
            }
            else if (choice == "4")
            {
                // Console.Write("Enter the filename to load the goals: ");
                // string filename = Console.ReadLine();
                // string[] parts = filename.Split();
                // string goalnameis = parts[0];
                // string descriptionis = parts[1];


                // if (System.IO.File.Exists(filename))
                // {
                //     Console.WriteLine($"{goalnameis} {descriptionis}");
                // }
            }
            else if (choice == "5")
            {
                Console.WriteLine("Select a goal to record an event:");


                for (int i = 0; i < goal.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goal[i].ToString()}");
                }

                Console.Write("Enter the number of the goal to record an event: ");
                string goalIndexInput = Console.ReadLine();

                if (int.TryParse(goalIndexInput, out int goalIndex) && goalIndex > 0 && goalIndex <= goal.Count)
                {
                    totalPoints += goal[goalIndex - 1].RecordEvent();
                }

            }
            else if (choice == "6")
            {
                continuegame = false;
            }

        }
    }
}



