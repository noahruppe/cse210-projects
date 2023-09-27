using System;

public class resume
{
    public string _personsName;

    public List<job>_jobs = new List<job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_personsName}");
        Console.WriteLine("Jobs:");


        foreach (job job in _jobs)
        {
            job.Display();
        }
    }



}