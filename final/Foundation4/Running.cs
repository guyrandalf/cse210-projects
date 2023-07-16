using System;

public class Running : Activity
{
    private float _pace;


    public Running(string date, int length, string activity, float distance) : base(date,length,activity)
    {
        _distance = distance;
    }


    public override void DisplaySummary()
    {
        CalculatePace();
        CalculateSpeed();
        Console.WriteLine($"{_date} {_activity} ({_length}) - Distance {_distance} km, Speed {_speed} km/h, Pace: {_pace} min/km");  
    }

    public override float CalculateSpeed()
    {
        _speed = (_distance / _length) * 60;
        
        return Convert.ToSingle(Math.Round(_speed,2));
    }

    public override float CalculatePace()
    {
        _pace = _length / _distance;
        return Convert.ToSingle(Math.Round(_pace,2));
    }

}