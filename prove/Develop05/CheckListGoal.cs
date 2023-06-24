using System;

public class CheckListGoal : Goal
{
    private int _timesToComplete = 3;

    private int _timesCompleted;

    private int _bonusPoints = 500;

    private bool _noBonusGiven = true;

    public CheckListGoal()
        : base()
    {
        _timesToComplete = SetTimesToComplete();
        _bonusPoints = SetBonusPoints();
        _type = GoalTypes.CheckListGoal;
    }

    public CheckListGoal(
        string title,
        string description,
        int points,
        int timesToComplete,
        int timesCompleted,
        int bonusPoints,
        bool isAchieved
    )
        : base(title, description, points, isAchieved)
    {
        _timesToComplete = timesToComplete;
        _timesCompleted = timesCompleted;
        _bonusPoints = bonusPoints;
        _type = GoalTypes.CheckListGoal;
    }

    private int SetBonusPoints()
    {
        Console.WriteLine("What is the bonus for accomplishing it that many times?");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int points))
        {
            return points;
        }
        else
        {
            Console.WriteLine($"Invalid input. Set to default{_bonusPoints}.");
            return _bonusPoints;
        }
    }

    private int SetTimesToComplete()
    {
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int times))
        {
            return times;
        }
        else
        {
            Console.WriteLine($"Invalid input. Set to default{_timesToComplete}.");
            return _timesToComplete;
        }
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        _goalIsAchieved = IsComplete();
        if (_goalIsAchieved && _noBonusGiven)
        {
            _noBonusGiven = false;
            return _pointsForGoal + _bonusPoints;
        }

        return _pointsForGoal;
    }

    private protected override bool IsComplete()
    {
        if (_timesCompleted >= _timesToComplete)
        {
            return true;
        }
        return false;
    }

    public int GetTimesToComplete()
    {
        return _timesToComplete;
    }

    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
}
