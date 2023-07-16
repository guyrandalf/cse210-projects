using System;

public class Reception : Event
{
    private string _emailAddress;

    public Reception(
        string title,
        string description,
        string date,
        string time,
        Address address,
        string type,
        string email
    )
        : base(title, description, date, time, address, type)
    {
        _emailAddress = email;
    }

    public void DisplayFullDetails()
    {
        base.DisplayStandardDetails();
        Console.WriteLine($"Kindly send an RSVP email to: {_emailAddress}");
    }
}
