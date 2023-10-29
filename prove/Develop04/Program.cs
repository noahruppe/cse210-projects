using System;
using System.Net.Security;

class Program
{
    static void Main(string[] args)
    {
        Activities activities = new Activities("hello", "bye");
        Console.WriteLine("Menu Options");
        Console.WriteLine("1: Start breathing activity");
        Console.WriteLine("2: Start reflecting activity");
        Console.WriteLine("3: Start listing activity");
        Console.WriteLine("4: Quit");
        string choice = Console.ReadLine();

        // Breathing breathing = new Breathing("This activity will help you by walking you through breathing in and out slowly to help you calm your mind.","good bye hope you have a good day.");
        // string breathing1 = breathing.GetStartDisplayMsg();
        // Console.WriteLine(breathing1);
        // activities.GetTimerInfo();
        // breathing.DisplayBreathing();
        
        
    }
}