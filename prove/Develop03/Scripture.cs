using System;

public class Scripture
{
    public Scripture(Reference reference, string scripture, Hint hint)
    {
        _reference = reference;
        _words = CreateWordList(scripture);
        _hint = hint;
    }

    private Reference _reference { get; set; }
    private List<Word> _words { get; set; }
    private Hint _hint { get; set; }
    private int _difficultyLevel { get; set; }

    private List<Word> CreateWordList(string scripture)
    {
        var wordList = new List<Word>();

        foreach (var word in scripture.Split(" "))
        {
            var _include = new Word(word);
            wordList.Add(_include);
        }

        return wordList;
    }

    public void HideWords()
    {
        foreach (var word in _words)
        {
            if (!word.isHidden())
            {
                var random = new Random();
                if (random.Next(_difficultyLevel) == 0)
                {
                    word.Hide();
                }
            }
        }
    }

    public void SetDifficultyLevel()
    {
        Console.WriteLine("Choose a Level. Enter a number between 1-4. (1 = Top Player - 4 = Beginner)");

        var _level = Console.ReadLine();
        var difficultyLevel = Int32.Parse(_level);
        if (difficultyLevel > 4)
        {
            _difficultyLevel = 4;
        }
        else if (difficultyLevel < 1)
        {
            _difficultyLevel = 1;
        }
        else
        {
            _difficultyLevel = difficultyLevel;
        }
    }

    public string GetText()
    {
        var scripture = "";
        scripture += _reference.GetText();
        foreach (var word in _words)
        {
            scripture += $" {word.GetText()}";
        }
        scripture += _hint.GetText();
        return scripture;
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.isHidden()) return false;
        }
        return true;
    }
}