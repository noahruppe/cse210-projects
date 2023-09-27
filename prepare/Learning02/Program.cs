using System;

class Program
{
    static void Main(string[] args)
    {
        job job1 = new job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startingYear = 2018;
        job1._endingYear = 2020;

        job job2 = new job();
        job2._jobTitle = "Project Manager";
        job2._company = "apple";
        job2._startingYear = 2020;
        job2._endingYear = 2023;

        resume myresume = new resume();
        myresume._personsName = "Noah";

        myresume._jobs.Add(job1);
        myresume._jobs.Add(job2);

        myresume.Display();

        



        
    }
}