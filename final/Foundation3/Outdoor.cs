using System;

public class Outdoor : Event
{
    private string _weather;

    public Outdoor(
        string title,
        string description,
        string date,
        string time,
        Address address,
        string type,
        string weather
    )
        : base(title, description, date, time, address, type)
    {
        _weather = weather;
    }

    public void DisplayFullDetails()
    {
        base.DisplayStandardDetails();
        Console.WriteLine($"We expect a {_weather} weather");
    }
}
