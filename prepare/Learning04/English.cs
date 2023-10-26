using System;


public class English : Assignments
{
    private string  _title = "";

    public English(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }
    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetWritingInfo()
    {
        return $"Name: {GetName()} \nTopic {GetTopic()} \nTitle: {GetTitle()}";
    }
}