using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> Entries { get; private set; }

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in Entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveEntries(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in Entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    public void LoadEntries(string fileName)
    {
        if (File.Exists(fileName))
        {
            Entries.Clear();

            foreach (string line in File.ReadLines(fileName))
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    DateTime date;
                    if (DateTime.TryParse(parts[0], out date))
                    {
                        Entry currentEntry = new Entry
                        {
                            Date = date,
                            Prompt = parts[1],
                            Response = parts[2]
                        };
                        Entries.Add(currentEntry);
                    }
                }
            }
            Console.WriteLine("Entries loaded successfully.");
        }
        else
        {
            Console.WriteLine("The specified file does not exist.");
        }
    }
}

