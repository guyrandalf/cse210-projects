using System;

public class Comment
{
    private string _date;
    private string _name;
    private string _content;

    public Comment(string date, string name, string content)
    {
        _date = date;
        _name = name;
        _content = content;
    }

    public string GetContent()
    {
        return _content;
    }

    public string GetComment()
    {
        return $"{_date} - {_name} - ";
    }
}
