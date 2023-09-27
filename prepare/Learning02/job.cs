using System;

public class job
{
    public string _jobTitle;
    public string _company;
    public int _startingYear;
    public int _endingYear;
    public void Display()
    {
        Console.WriteLine($"{_jobTitle}-{_company}-{_startingYear}-{_endingYear}");
    }
}