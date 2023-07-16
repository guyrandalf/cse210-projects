using System;

public class Bicycle : Activity
{
    private float _pace;

    public Bicycle(string date, int length, string activity, float speed)
        : base(date, length, activity)
    {
        _speed = speed;
    }

    public override void DisplaySummary()
    {
        CalculateDistance();
        CalculatePace();
        Console.WriteLine(
            $"{_date} {_activity} ({_length}) - Distance {_distance} km, Speed {_speed} km/h, Pace: {_pace} min/km"
        );
    }

    public override float CalculatePace()
    {
        _pace = _length / _distance;
        return Convert.ToSingle(Math.Round(_pace, 2));
    }

    public override float CalculateDistance()
    {
        _distance = (_speed * _length) / 60;
        return Convert.ToSingle(Math.Round(_distance, 2));
    }
}
