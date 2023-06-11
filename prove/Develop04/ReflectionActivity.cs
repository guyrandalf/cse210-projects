using static Utilities;
public class ReflectionActivity : Activity
{

    private List<string> _questions { get; set; }

    private List<string> _prompts { get; set; }

    private List<string> _unusedQuestions { get; set; }

    private List<string> _unusedPrompts { get; set; }

    public ReflectionActivity()
    {
        _name = "Reflecting Activity";
        _desc = "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _questions = new List<string> {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        _prompts = new List<string> {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
    }

    public void RunActivity()
    {
        RefreshLists();
        BeginActivity(DisplayReflectionActivity);
    }

    private void DisplayReflectionActivity()
    {
        var questionTime = Math.Ceiling(_duration / 10.0);
        var count = _questions.Count();
        if (count < questionTime)
        {
            questionTime = count;
            _duration = count * 10;
            Console.WriteLine($"Time was too long. Shortened to {_duration} Seconds ");
        }
        DisplayReflectingPrompt();
        while (questionTime > 0)
        {
            Console.Write($"{GetRandomPrompt(_unusedQuestions)}");
            Spin(10);
            Console.WriteLine();
            questionTime--;
        }
    }

    private void DisplayReflectingPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {GetRandomPrompt(_unusedPrompts)} --- ");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in ");
        DisplayCountDown(5);
        Console.Clear();
    }

    private void RefreshLists()
    {
        if (ListNeedsRefreshed(_unusedPrompts))
        {
            _unusedPrompts = _prompts;
        }

        if (ListNeedsRefreshed(_unusedQuestions))
        {
            _unusedQuestions = _questions;
        }
    }
}