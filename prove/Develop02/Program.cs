using System;
using System.Data.Common;
using System.Runtime.InteropServices.Marshalling;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Menu menu = new Menu(journal);

        Console.WriteLine("Welcome to the Journal App!");
        menu.Run();

        Console.WriteLine("Goodbye!");


    }
}



