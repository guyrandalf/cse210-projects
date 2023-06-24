public static class Menu
{
    private const string _menuHeader = "Menu:";

    private const string _menuFooter = "Select an option from the menu: ";

    private const string _goalMenuHeader = "Goal Types: ";

    private const string _goalMenuFooter = "Select the goal type: ";
    private static readonly Dictionary<int, string> _menuOptions = new Dictionary<int, string>()
    {
        { 1, "Create New Goal" },
        { 2, "List Goals" },
        { 3, "Save Goals" },
        { 4, "Load Goals" },
        { 5, "Record Event" },
        { 6, "Quit" }
    };
    private static readonly Dictionary<int, string> _goalMenuOptions = new Dictionary<int, string>()
    {
        { 1, "Simple Goal" },
        { 2, "Eternal Goal" },
        { 3, "Checklist Goal" }
    };

    public static string GetInput(bool isGoalMenu = false)
    {
        string header;
        string footer;
        Dictionary<int, string> options;
        if (isGoalMenu)
        {
            header = _goalMenuHeader;
            footer = _goalMenuFooter;
            options = _goalMenuOptions;
        }
        else
        {
            header = _menuHeader;
            footer = _menuFooter;
            options = _menuOptions;
        }
        Console.WriteLine($"{header}");
        for (int i = 1; i <= options.Count(); i++)
        {
            Console.WriteLine($"{i}. {options[i]}");
        }
        Console.WriteLine($"{footer}");
        return Console.ReadLine();
    }

    public static string GetResponse()
    {
        Console.WriteLine(
            "You have unsaved goal information. Would you like to save before quitting? y/n: "
        );
        return Console.ReadLine();
    }

    public static bool PromptSaveOnQuit()
    {
        var response = GetResponse();
        if (response.ToLower() == "y")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
