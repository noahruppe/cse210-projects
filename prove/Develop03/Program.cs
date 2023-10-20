using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Mark 10:7-8");
        Scripture scripture = new Scripture(reference, "for this cause shall a man leave his father and mother and cleave to his wife and they twain shall be one flesh so then they are no more twain but one flesh");

        while (!scripture.IsComplete())
        {
            Console.Clear();
            Console.WriteLine($"Scripture Reference: {reference.GetTitle()}");
            Console.WriteLine(scripture.RenderDisplay());
            Console.WriteLine("\nPress Enter to hide a word or type 'quit' to end.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            else if (input == "")
            {
                scripture.HideRandomWord();
                scripture.HideRandomWord();
                scripture.HideRandomWord();
            }
        }

        while (!scripture.IsComplete())
        {
            scripture.HideRandomWord();
        }

        Console.Clear();
        Console.WriteLine($"Scripture Reference: {reference.GetTitle()}");
        Console.WriteLine(scripture.RenderDisplay());
        Console.WriteLine("All words have been hidden. Press Enter to continue.");

        bool answer = true;

        while (answer)
        {     /*this is what I am doing for my extra credit the user has the option to say if he is confident enough to write the code or not*/
            Console.WriteLine("Do you want to try to type the scripture by memory? (Yes/No)");
            string response = Console.ReadLine().ToLower();

            if (response == "no")
            {
                Console.WriteLine("Have a good day");
                answer = false;
            }
            else if (response == "yes")
            {
                Console.WriteLine("Enter the entire text to check if it's correct (If you've changed your mind, just type quit to exit).");
                string input = Console.ReadLine().ToLower();

                if (input == "quit")
                {
                    Console.WriteLine("Have a nice day");
                    answer = false;
                }
                else
                {
                    string result = scripture.IsCorrect(input);
                    Console.WriteLine(result);

                    if (result == "You got it!")
                    {
                        Console.WriteLine("Press Enter to exit.");
                        Console.ReadLine();
                        answer = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'Yes' or 'No'.");
            }
        }
    }
}
