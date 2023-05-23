using System;

public class Word
{
    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    private string _word { get; set; }
    private bool _isHidden { get; set; }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool isHidden()
    {
        return _isHidden;
    }

    public string GetText()
    {
        if (isHidden())
        {
            var word = "";
            foreach (var letter in _word)
            {
                word += "_";
            }
            return word;
        }

        return _word;
    }
}