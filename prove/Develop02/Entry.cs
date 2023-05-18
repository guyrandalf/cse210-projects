using System;
public class Entry
{
    public string _prompt;
    public DateTime _date;
    public string _answer;

    public string Prompt
    {
        get
        {
            return _prompt;
        }
    }

    public string Answer
    {
        get
        {
            return _answer;
        }
    }

    public DateTime Date
    {
        get
        {
            return _date;
        }
    }

    public Entry(string prompt, string answer)
    {
        _prompt = prompt;
        _answer = answer;
        _date = DateTime.Now;
    }

    public Entry(string prompt, string answer, DateTime date)
    {
        _prompt = prompt;
        _answer = answer;
        _date = date;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date.ToString("dd/MM/yyyy")} - Prompt: {_prompt}");
        Console.WriteLine(_answer);
        Console.WriteLine("");
    }

}