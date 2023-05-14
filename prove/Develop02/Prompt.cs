using System;

public class Prompt{
/* Generate and display a random prompt from a list of prompts to the user */

    public List<string> _prompts;

    public string _selectedPrompt;

    public void GetRandomPrompt(){
        var random = new Random();
        int index = random.Next(_prompts.Count);
        _selectedPrompt = _prompts[index];
    }

    public void Display(){
        Console.WriteLine($"{_selectedPrompt}");
    }
}