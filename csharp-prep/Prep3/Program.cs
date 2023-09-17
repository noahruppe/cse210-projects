using System;

class Program
{
    static void Main(string[] args)
    {

         string answer2="";
         while (answer2 != "no")
         {
         


            Random randomizer = new Random();
            int number = randomizer.Next(1,100);

            Console.Write("What is your guess? ");
            string answer1 = Console.ReadLine();
            int number1 = int.Parse(answer1);

            int count = 0;
            
            while (number1 != number)
            {
                count ++;
                if (number1 > number)
                {
                    Console.WriteLine("Lower");
                    Console.Write("guess again ");
                    answer1= Console.ReadLine();
                    number1 = int.Parse(answer1);
                }
                else if (number1 < number)
                {
                    Console.WriteLine("Higher");
                    Console.Write("guess again ");
                    answer1= Console.ReadLine();
                    number1 = int.Parse(answer1);
                }
            }
                Console.WriteLine("you got it");
                Console.WriteLine($"the number of guesses: {count+1}");

                Console.Write("Would you like to play again? ");
                answer2 = Console.ReadLine();
         }
            
    }
}


