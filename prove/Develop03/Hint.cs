using System;

public class Hint
{
    public Hint(string hint)
    {
        _hint = hint;
    }

    private string _hint { get; set; }

    public string GetText()
    {
        if (_hint == "")
        {
            return "\nHint: No hint available for this one";
        }
        return $"\nHint: {_hint}";
    }
}