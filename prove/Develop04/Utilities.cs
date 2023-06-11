public static class Utilities
{

    public static string GetRandomPrompt(List<string> list)
    {
        var count = list.Count();
        Random rand = new Random();
        var chosenPrompt = list[rand.Next(0, count)];
        list.Remove(chosenPrompt);
        return chosenPrompt;
    }

    public static bool ListNeedsRefreshed(List<string> unusedList)
    {
        if (unusedList == null || unusedList.Count() == 0)
        {
            return true;
        }
        return false;
    }
}