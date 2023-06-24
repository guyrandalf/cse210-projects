using System.Text;

public class Progress
{
    private int _totalPoints = 0;
    private Dictionary<int, Goal> _goalDict = new Dictionary<int, Goal>();
    private bool _isSaved;
    private string _loadedFileName;

    public void DisplayGoalList()
    {
        Console.WriteLine("Your goals are:");
        for (int i = 1; i <= _goalDict.Count(); i++)
        {
            Console.Write(
                $"{i}. {IsAchievedDisplay(_goalDict[i].GetGoalIsAcheived())} {_goalDict[i].GetGoalTitle()} ({_goalDict[i].GetGoalDescription()})"
            );
            if (_goalDict[i] is CheckListGoal checklistGoal)
            {
                Console.Write(
                    $"-- Currently Completed: {checklistGoal.GetTimesCompleted()}/{checklistGoal.GetTimesToComplete()}"
                );
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        DisplayTotalPoints();
        Console.WriteLine();
    }

    public void DisplayTotalPoints()
    {
        Console.WriteLine($"You have {_totalPoints} points");
        DisplayLevel();
    }

    private string IsAchievedDisplay(bool isComplete)
    {
        if (isComplete)
        {
            return "[X]";
        }
        return "[ ]";
    }

    public int GetGoalListIncrementNumber()
    {
        return _goalDict.Count() + 1;
    }

    public void AddGoal(GoalTypes type)
    {
        switch (type)
        {
            case GoalTypes.SimpleGoal:
                _goalDict.Add(GetGoalListIncrementNumber(), new Goal());
                break;
            case GoalTypes.EternalGoal:
                _goalDict.Add(GetGoalListIncrementNumber(), new EternalGoal());
                break;
            case GoalTypes.CheckListGoal:
                _goalDict.Add(GetGoalListIncrementNumber(), new CheckListGoal());
                break;
        }
        _isSaved = false;
    }

    public void GetAndRecordEvent()
    {
        for (int i = 1; i <= _goalDict.Count(); i++)
        {
            Console.WriteLine($"{i}. {_goalDict[i].GetGoalTitle()}");
        }
        Console.WriteLine("Which goal did you complete? ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int goalNumber))
        {
            if (goalNumber <= _goalDict.Count())
            {
                _totalPoints += _goalDict[goalNumber].RecordEvent();
                Console.WriteLine($"Great job!");
                DisplayTotalPoints();
                _isSaved = false;
            }
            else
            {
                Console.WriteLine("Invalid number entered.");
            }
        }
        else
        {
            Console.WriteLine($"Invalid input.");
        }
    }

    public void Save(string fileName)
    {
        String file = @$"{fileName}";
        StringBuilder goals = new StringBuilder();
        goals.AppendLine(_totalPoints.ToString());
        foreach (KeyValuePair<int, Goal> goal in _goalDict)
        {
            String newLine;
            if (goal.Value._type == GoalTypes.CheckListGoal)
            {
                var checklistGoal = (CheckListGoal)goal.Value;
                newLine =
                    $"{checklistGoal.GetGoalType()}|{checklistGoal.GetGoalTitle()}|{checklistGoal.GetGoalDescription()}|{checklistGoal.GetPointsForGoal()}|{checklistGoal.GetGoalIsAcheived()}|{checklistGoal.GetBonusPoints()}|{checklistGoal.GetTimesToComplete()}|{checklistGoal.GetTimesCompleted()}";
            }
            else
            {
                newLine =
                    $"{goal.Value.GetGoalType()}|{goal.Value.GetGoalTitle()}|{goal.Value.GetGoalDescription()}|{goal.Value.GetPointsForGoal()}|{goal.Value.GetGoalIsAcheived()}";
            }
            goals.AppendLine(newLine);
        }

        try
        {
            File.WriteAllText(file, goals.ToString());
            Console.WriteLine($"Goals saved to {file}");
            _isSaved = true;
        }
        catch (Exception)
        {
            Console.WriteLine("Could not write data to that file.");
            return;
        }
    }

    public void Load(string file)
    {
        int type = 0;
        int title = 1;
        int description = 2;
        int pointsForGoal = 3;
        int goalIsAcheived = 4;
        int bonusPoints = 5;
        int timesToComplete = 6;
        int timesCompleted = 7;

        if (file == _loadedFileName)
        {
            Console.WriteLine("File has already been loaded into this session.");
            return;
        }
        try
        {
            using (var reader = new StreamReader(@$"{file}"))
            {
                _totalPoints = int.Parse(reader.ReadLine());
                while ((!reader.EndOfStream))
                {
                    var values = reader.ReadLine().Split('|');
                    if (values[type] == GoalTypes.CheckListGoal.ToString())
                    {
                        _goalDict.Add(
                            GetGoalListIncrementNumber(),
                            new CheckListGoal(
                                values[title],
                                values[description],
                                int.Parse(values[pointsForGoal]),
                                int.Parse(values[timesToComplete]),
                                int.Parse(values[timesCompleted]),
                                int.Parse(values[bonusPoints]),
                                bool.Parse(values[goalIsAcheived])
                            )
                        );
                    }
                    else if (values[type] == GoalTypes.EternalGoal.ToString())
                    {
                        _goalDict.Add(
                            GetGoalListIncrementNumber(),
                            new EternalGoal(
                                values[title],
                                values[description],
                                int.Parse(values[pointsForGoal]),
                                bool.Parse(values[goalIsAcheived])
                            )
                        );
                    }
                    else if (values[type] == GoalTypes.SimpleGoal.ToString())
                    {
                        _goalDict.Add(
                            GetGoalListIncrementNumber(),
                            new Goal(
                                values[title],
                                values[description],
                                int.Parse(values[pointsForGoal]),
                                bool.Parse(values[goalIsAcheived])
                            )
                        );
                    }
                }
            }
        }
        catch
        {
            Console.WriteLine("Could not load data from this file.");
            return;
        }
        _loadedFileName = file;
    }

    public void DisplayLevel()
    {
        int level = _totalPoints / 250 + 1;
        Console.WriteLine($"You are currently at level {level}");
    }

    public bool IsSaved()
    {
        return _isSaved;
    }

    public string GetLoadedFileName()
    {
        return _loadedFileName;
    }
}
