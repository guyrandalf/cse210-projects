using System;
using System.IO;
public class Entry
{
    public List<string> temporalEntries;
    public string input;
    public string date;
    public string cleanData;    


    public string GetInput()
    {
        Console.Write(">>> ");
        return input = Console.ReadLine();
    }
    public string GetEntryDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        return date = theCurrentTime.ToString("dd/MM/yyyy");
    }
    public string CleanInput()
    {
        string Trim()
        {
            string trimmed = input.Trim();
            return trimmed;
        }
        string ToUpperCase(string trimmed)
        {
            if (string.IsNullOrEmpty(trimmed))
            {
                return string.Empty;
            }
            return $"{trimmed[0].ToString().ToUpper()}{trimmed.Substring(1)}";
        }

        cleanData = Trim();
        cleanData = ToUpperCase(input);
        return cleanData;
    }

    public void SaveEntry(string prompt)
    {
        CleanInput();
        GetEntryDate();
        input = $"{date} - Prompt: {prompt}\n{cleanData}";
    }

}