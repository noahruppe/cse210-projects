using System;

public class SaveToFile
{
    public static void SavedEntries(string fileName , List<string> entries)
    {
        File.WriteAllLines(fileName,entries);
    }
}