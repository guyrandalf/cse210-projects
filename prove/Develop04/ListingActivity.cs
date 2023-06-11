using static Utilities;
public class ListingActivity : Activity
{

    private List<string> _prompts { get; set; }

    private List<string> _unusedPrompts { get; set; }

    public ListingActivity()
    {
        _name = "Listing Activity";
        _desc = "reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string> {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?"
        };
    }

    public void RunActivity()
    {
        RefreshList();
        BeginActivity(DisplayListingActivity);
    }

    private void DisplayListingActivity()
    {
        DisplayListingPrompt();
        var startTime = DateTime.Now;
        var endTime = startTime.AddSeconds(_duration);
        var responseCount = 0;
        Console.WriteLine();
        while (endTime >= DateTime.Now)
        {
            Console.Write("> ");
            Console.ReadLine();
            responseCount++;
        };
        Console.WriteLine($"You have listed {responseCount} items");
        Spin();
        Console.WriteLine();
    }

    private void DisplayListingPrompt()
    {
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($" --- {GetRandomPrompt(_prompts)} --- ");
        Console.Write("You may begin in ");
        DisplayCountDown(5);
    }

    private void RefreshList()
    {
        if (ListNeedsRefreshed(_prompts))
        {
            _unusedPrompts = _prompts;
        }
    }


}