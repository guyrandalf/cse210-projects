using System;

public class Activity
{
    protected string _date;
    protected int _length;
    protected float _distance;
    protected float _speed;
    protected string _activity;

    public Activity(string date, int length, string activity)
    {
        _date = date;
        _length = length;
        _activity = activity;
    }

    public virtual void DisplaySummary() { }

    public virtual float CalculateSpeed()
    {
        return _speed;
    }

    public virtual float CalculatePace()
    {
        return 0.0f;
    }

    public virtual float CalculateDistance()
    {
        return _distance;
    }
}
