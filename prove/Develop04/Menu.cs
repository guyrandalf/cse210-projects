public static class Menu
{
    private const string _menuHeader = "Menu Options:";

    private const string _menuFooter = "Select a choice from the menu: ";

    private static readonly Dictionary<int, String> _options = new Dictionary<int, string>(){
        {1, "Start Breathing activity"},
        {2, "Start Reflection activity"},
        {3, "Start Listing activity"},
        {4, "Quit"}
    };

    public static string GetInput()
    {
        Console.WriteLine($"{_menuHeader}");
        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine($"{i}. {_options[i]}");
        }
        return Console.ReadLine();
    }
}