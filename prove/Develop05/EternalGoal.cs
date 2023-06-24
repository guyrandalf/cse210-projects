using System;

public class EternalGoal : Goal
{
    public EternalGoal()
        : base()
    {
        _type = GoalTypes.EternalGoal;
    }

    public EternalGoal(string title, string description, int points, bool isAchieved)
        : base(title, description, points, isAchieved)
    {
        _type = GoalTypes.EternalGoal;
    }

    public override int RecordEvent()
    {
        _goalIsAchieved = IsComplete();
        return _pointsForGoal;
    }

    private protected override bool IsComplete()
    {
        return false;
    }
}
