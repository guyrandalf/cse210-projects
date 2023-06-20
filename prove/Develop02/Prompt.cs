using System;

public class Prompt
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void Display()
    {
        Console.WriteLine(GetRandomPrompt());
    }
}
