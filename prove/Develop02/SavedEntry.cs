using System;

public class SavedEntry
{
    public string prompt;
    public string response;
    public DateTime date;

    public void SetPrompt(string newPrompt)
    {
        prompt = newPrompt;
    }
    public void SetResponse(string newResponse)
    {
        response = newResponse;
    }
    public void SeTDate(DateTime newDate)
    {
        date = newDate;
    }
    public string GetPrompt()
    {
        return prompt;
    }
    public string GetResponse()
    {
        return response;
    }
    public DateTime GetDate()
    {
        return date;
    }
}

