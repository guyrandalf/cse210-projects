using System;

public class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _eventType;

    public Event(
        string title,
        string description,
        string date,
        string time,
        Address address,
        string type
    )
    {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = type;
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine($"Event Name: {_eventTitle}");
        Console.WriteLine($"Description? {_description}");
        Console.WriteLine($"Time?: {_date}");
        Console.WriteLine($"Venue?: {_address.CreateAddress()}");
    }

    public void DisplayShortDescription()
    {
        Console.WriteLine($"You are cordially invited to a {_eventType}");
        Console.WriteLine(_eventTitle);
        Console.WriteLine(_date);
    }
}
