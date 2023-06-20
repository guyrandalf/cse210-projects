using System;
using System.Collections.Generic;


public class Journal
{

    public List<Entry> _entries;
    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void SaveEntry(Entry entry)
    {
        _entries.Add(entry);
        Console.WriteLine("Entry saved: " + entry._answer); // Print the saved entry for verification        

    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveInFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry.Prompt.Replace(",", "|||")}, {entry.Answer.Replace(",", "|||")},{entry.Date.ToString()}");
            }
        }
    }

    public void LoadEntriesFromFile(string fileName)
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                string[] entryData = reader.ReadLine().Split(',');
                string prompt = entryData[0].Replace("|||", ",");
                string answer = entryData[1].Replace("|||", ",");
                DateTime date = DateTime.Parse(entryData[2]);
                Entry entry = new Entry(prompt, answer, date);
                SaveEntry(entry);
            }
        }
    }
}