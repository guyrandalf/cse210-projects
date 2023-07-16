using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int length, string activity, int laps) : base(date,length,activity)
    {
        _laps = laps;
    }


    public override void DisplaySummary()
    {      
        CalculateDistance();
        CalculateSpeed();
        Console.WriteLine($"{_date} {_activity} ({_length}) - Distance {_distance} km, Speed {_speed} km/h, Laps: {_laps}");  
    }

    public override float CalculateSpeed()
    {
        _speed = (_distance / _length) * 60;
        return Convert.ToSingle(Math.Round(_speed,2));
    }
    public override float CalculateDistance()
    {
        float distance = (_laps * 50);
        
        _distance = distance / 1000;
        return _distance;
    }
    
}