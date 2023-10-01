using System;
using System.Data.Common;
using System.Runtime.InteropServices.Marshalling;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        Menu menu1 = new Menu();
        menu1._write ="1";
        menu1._display="2";
        menu1._Load="3";
        menu1._Save="4";
        menu1._quite="5";

        bool isRunning = true;

        SavedEntries savedEntries = new SavedEntries();

        while (isRunning)
        {
            Console.WriteLine("Menu");
            Console.WriteLine($"{menu1._write} Write: ");
            Console.WriteLine($"{menu1._display} Display: ");
            Console.WriteLine($"{menu1._Load} Load: ");
            Console.WriteLine($"{menu1._Save} Save: ");
            Console.WriteLine($"{menu1._quite} Quit: ");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            if (choice == menu1._write)
            {
                HandleWriteOption(savedEntries);
            }
            else if  (choice == menu1._display)
            {
                HandleDisplayOption(savedEntries);
            }
            else if (choice == menu1._Load)
            {
                HandleLoadOption(savedEntries);
            }
            else if (choice == menu1._Save)
            {
                HandleSavedEntries(savedEntries);
            }
            else if (choice == menu1._quite)
            {
                isRunning = false;
            }
            static void HandleWriteOption(SavedEntries savedEntries)
            {
                Console.WriteLine("Would you like to create a custom prompt (Yes/No)");
                string customPromptChoice = Console.ReadLine();

                string randomPrompt = "";
                /*I added this to the code so that the user can have the option to write their own prompt for when they have things they want
                to keep track of like general conference messages for example they could write prompt words of russel m nelson. and then
                they can write their thoughts on his talk or things that inspired them this is my attempt to get the full 100% */
                if (customPromptChoice.ToLower() == "yes")
                {
                    Console.WriteLine("Enter you prompt: ");
                    randomPrompt = Console.ReadLine();
                }
                else
                {

                    Prompts Prompt1 = new Prompts();
                    Prompt1._interestingPerson = "Who was the most interesting person I interacted with today?";
                    Prompt1._bestPartOfDay = "What was the best part of my day?";
                    Prompt1._lordsHand = "How did I see the hand of the Lord in my life today?";
                    Prompt1._emotionFelt = "What was the strongest emotion I felt today?";
                    Prompt1._doOver = "If I had one thing I could do over today, what would it be?";

                    Randomizer randomizer = new Randomizer();
                    randomizer.AddPrompt(Prompt1);

                    randomPrompt = randomizer.GetRandomPrompt();
                }

                Console.WriteLine($"Prompt: {randomPrompt} ");

                Entry entry = new Entry();
                string _userResponse = entry._userResponse();


                SavedEntry savedEntry = new SavedEntry();

                savedEntry.SetPrompt(randomPrompt);
                savedEntry.SetResponse(_userResponse);
                savedEntry.SeTDate(DateTime.Now);

                savedEntries.AddSavedEntry(savedEntry);

            }
            static void HandleDisplayOption(SavedEntries savedEntries)
            {
                List<string> entriesTODisplay = savedEntries.GetEntries();

                Console.WriteLine("Entries for the day:");
                if (entriesTODisplay.Count == 0 )
                {
                    Console.Write("You do not have any entries for the day.");
                }
                else
                {
                    foreach (string entryText in entriesTODisplay)
                    {
                        Console.WriteLine(entryText);
                    }
                }
            }
            static void HandleLoadOption(SavedEntries savedEntries)
            {
                Console.WriteLine("Enter a file name to load entries from: ");
                string fileName = Console.ReadLine();

                string [] lines = File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    savedEntries.AddEntry(line);
                }
            }
            static void HandleSavedEntries(SavedEntries savedEntries)
            {
                Console.WriteLine("Enter a file name to save your entries:");
                string fileName = Console.ReadLine();
    
                SaveToFile.SavedEntries(fileName, savedEntries.GetEntries());
    
                Console.WriteLine($"Entries saved to {fileName}.");
            }


        }


    }
}

