using System;

public static class Menu
{
    private const string _menu = "Press the enter key to continue. Type Q to exit";

    public static string GetInput()
    {
        Console.Write($"{_menu}: ");
        return Console.ReadLine();
    }
}