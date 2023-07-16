using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(
        string title,
        string description,
        string date,
        string time,
        Address address,
        string type,
        string speaker,
        int capacity
    )
        : base(title, description, date, time, address, type)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void DisplayFullDetails()
    {
        base.DisplayStandardDetails();
        Console.WriteLine($"Speaker: {_speaker}, Capacity: {_capacity}");
    }
}
