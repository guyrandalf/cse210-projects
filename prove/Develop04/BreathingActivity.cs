public class BreathingActivity : Activity
{

    private const string _breathIn = "Breathe in...";

    private const string _breathOut = "Now breathe out...";

    private const int _breathInTime = 4;

    private const int _breathOutTime = 6;

    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _desc = "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void RunActivity()
    {
        BeginActivity(DisplayBreathingActivity);
    }

    private void DisplayBreathingActivity()
    {
        var breaths = Math.Ceiling(_duration / 10.0);
        while (breaths > 0)
        {
            Console.WriteLine();
            Console.Write($"{_breathIn}");
            DisplayCountDown(_breathInTime);
            Console.WriteLine();
            Console.Write($"{_breathOut}");
            DisplayCountDown(_breathOutTime);
            Console.WriteLine();
            breaths--;
        }
    }
}