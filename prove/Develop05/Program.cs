class Program
{
    static void Main(string[] args)
    {
        Goals goals = new Goals(0,"","",0);
        bool continueprogram = true;
        while (continueprogram)
        {

            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create a goal");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Which would you like to choose type a number: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("\nWhich type of goal would you like to do? ");
                Console.WriteLine("1. Simple Goal: ");
                Console.WriteLine("2. Eternal Goal: ");
                Console.WriteLine("3. CheckList Goal");
                Console.Write("Please type the number of what you want to do. ");
                string choice2 = Console.ReadLine();
                if (choice2 == "1")
                {
                    SimpleGoals simpleGoals = new SimpleGoals(0);
                    goals.AddItemToList(simpleGoals);
                }
                else if (choice2 == "2")
                {
                    EternalGoals eternalGoals = new EternalGoals(0);
                    goals.AddItemToList(eternalGoals);
                }
                else if (choice2 == "3")
                {
                    CheckListGoals checklistGoal = CheckListGoals.CreateCheckListGoal();
                    goals.AddItemToList(checklistGoal);
                }

            }
            else if (choice == "2")
            {
                for (int i = 0; i < goals.GoalsList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goals.GoalsList[i].DisplayInfo()}");
                }

            }
            else if (choice == "3")
            {
                Console.Write("Enter the filename to save goals: ");
                string fileName = Console.ReadLine();
                goals.SaveGoals(fileName);
                Console.WriteLine($"Goals saved to {fileName}.");

            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename to load goals: ");
                string fileName = Console.ReadLine();
                goals.LoadGoals(fileName);

            }
            else if (choice == "5")
            {
                Console.WriteLine("\nEnter the index of the goal for which you want to record an event:");
                for (int i = 0; i < goals.GoalsList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goals.GoalsList[i].GetGoalName()}");
                }



                int index;
                if (int.TryParse(Console.ReadLine(), out index) && index >= 1 && index <= goals.GoalsList.Count)
                {
                    // Retrieve the selected goal
                    Goals selectedGoal = goals.GoalsList[index - 1];

                    if (selectedGoal is SimpleGoals simpleGoal)
                    {
                        // Record event for the SimpleGoals
                        simpleGoal.RecordEvent();
                    }
                    else if (selectedGoal is CheckListGoals checklistGoal)
                    {
                        // Record event for the CheckListGoals
                        checklistGoal.RecordEvent();
                        checklistGoal.DisplayProgress(); // Optionally display progress
                    }
                    else if(selectedGoal is EternalGoals eternalGoals)
                    {
                        eternalGoals.RecordEvent();
                        Console.WriteLine("Event recording not supported for this goal type.");
                    }

                    // Display updated information
                    Console.WriteLine(selectedGoal.DisplayInfo());
                }
                else
                {
                    Console.WriteLine("Invalid index. Please enter a valid index.");
                }

                        }
                        else if (choice == "6")
                        {
                            continueprogram = false;
                        }
                    }
                }
}


