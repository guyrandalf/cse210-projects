using System;

public class Prompt{
/* Generate and display a random prompt from a list of prompts to the user */

    public List<string> prompts;

    public string selectedPrompt;

    public void GetRandomPrompt(){
        var random = new Random();
        int index = random.Next(prompts.Count);
        selectedPrompt = prompts[index];
    }

    public void Display(){
        Console.WriteLine($"{selectedPrompt}");
    }
}