using System;
using System.IO;
public class Entry
{
    public List<string> _temporalEntries;
    public string _input;
    public string _date;
    public string _cleanData;    


    public string GetInput()
    {
        Console.Write(">>> ");
        return _input = Console.ReadLine();
    }
    public string GetEntryDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        return _date = theCurrentTime.ToString("dd/MM/yyyy");
    }
    public string CleanInput()
    {
        string Trim()
        {
            string trimmed = _input.Trim();
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

        _cleanData = Trim();
        _cleanData = ToUpperCase(_input);
        return _cleanData;
    }

    public void SaveEntry(string prompt)
    {
        CleanInput();
        GetEntryDate();
        _input = $"{_date} - Prompt: {prompt}\n{_cleanData}";
    }

}