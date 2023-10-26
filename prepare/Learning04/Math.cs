using System;


public class Math : Assignments
{
    private string _textbookSection = "";

    private string _problems = "";

    public Math(string name , string topic, string section, string problem) : base(name , topic)
    {
        _textbookSection = section;
        _problems = problem;
    }
    public string GetSection()
    {
        return _textbookSection;
    }
    public void SetSection(string section)
    {
        _textbookSection = section;
    }
    public string GetProblem()
    {
        return _problems;
    }
    public void SetProblem(string problem)
    {
        _problems = problem;
    }
    public string GetHomeWorkList()
    {
        return $"Name: {GetName()} \nTopic: {GetTopic()} \nSection: {GetSection()} \nProblem: {GetProblem()}";
    }

}