using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a list of numbers type 0 when finished. ");
        List<int> numbers = new List<int>();

        while (true)
        {
            int number1=int.Parse(Console.ReadLine());

            if (number1 == 0)
                {
                    break;
                } 
            numbers.Add(number1);

        }
        int sum =0;
        
        for(int i =0; i < numbers.Count; i++)
        sum+=numbers[i];
        Console.WriteLine($"The sum of the numbers is {sum}");

        int counter= numbers.Count;
        Console.WriteLine($"The average is: {sum/counter}");

        int BiggestNumber= -1;
        for (int number=0;number<numbers.Count;number++)
        if (numbers[number]>BiggestNumber)
        {
            BiggestNumber = numbers[number];
        }
        Console.WriteLine($"The biggest number is: {BiggestNumber}");
        int SmallestNumber=int.MaxValue;
        for (int i =0; i <numbers.Count; i++)
        if (numbers[i]<SmallestNumber)
        {
            SmallestNumber=numbers[i];
        }
        Console.WriteLine($"The smallest number is: {SmallestNumber}");
        



    }
}