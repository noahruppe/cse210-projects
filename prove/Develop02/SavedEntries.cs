using System;


public class SavedEntries
{
    public List<string>_entries = new List<string>();

    public void AddEntry(string entry)
    {
        _entries.Add(entry);
    }
    public void AddSavedEntry(SavedEntry savedEntry)
    {
        string savedEntryString = $"Prompt: {savedEntry.GetPrompt()}{Environment.NewLine}Date: {savedEntry.GetDate()}{Environment.NewLine}Rsponse: {savedEntry.GetResponse()}";
        _entries.Add(savedEntryString);
    }
    public List<string> GetEntries()
    {
        return _entries;
    }
}



