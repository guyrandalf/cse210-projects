using System;

//Ways I exceeded requirement:
//Program checks if goals have been altered since the last save and prompts user to save before quitting. The previously loaded file name will be used to save.
//Prevents user from loading a file with the same filename more than once.

class Program
{
    static void Main(string[] args)
    {
        var isGoalMenu = true;
        var quit = false;
        string file;
        var progress = new Progress();
        while (!quit)
        {
            var input = Menu.GetInput();
            switch (input)
            {
                case "1":
                    Console.Clear();
                    input = Menu.GetInput(isGoalMenu);
                    switch (input)
                    {
                        case "1":
                            progress.AddGoal(GoalTypes.SimpleGoal);
                            break;
                        case "2":
                            progress.AddGoal(GoalTypes.EternalGoal);
                            break;
                        case "3":
                            progress.AddGoal(GoalTypes.CheckListGoal);
                            break;
                    }
                    break;
                case "2":
                    Console.Clear();
                    progress.DisplayGoalList();
                    break;
                case "3":
                    Console.Clear();
                    Console.Write($"Enter the name of the file to save to: ");
                    file = Console.ReadLine();
                    progress.Save(file);
                    Console.Write($"File Saved! ");
                    break;
                case "4":
                    Console.Clear();
                    Console.Write($"Enter the name of the file to load: ");
                    file = Console.ReadLine();
                    progress.Load(file);
                    break;
                case "5":
                    Console.Clear();
                    if (progress.GetGoalListIncrementNumber() > 1)
                    {
                        progress.GetAndRecordEvent();
                    }
                    else
                    {
                        Console.WriteLine("Please create a new goal.");
                    }
                    break;
                case "6":
                    if (!progress.IsSaved())
                    {
                        var isConfirmed = Menu.PromptSaveOnQuit();
                        if (isConfirmed)
                        {
                            Console.Clear();
                            file = progress.GetLoadedFileName();
                            if (file == null)
                            {
                                Console.Write($"Enter the name of the file to save to: ");
                                file = Console.ReadLine();
                            }
                            progress.Save(file);
                            Console.Write($"File saved as {file}!");
                        }
                    }
                    quit = true;
                    break;
                default:
                    break;
            }
        }
    }
}
