using System;

public class Reference
{
    public Reference(string book, int chapter, int verseStart)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    private string _book { get; set; }
    private int _chapter { get; set; }
    private int _verseStart { get; set; }
    private int _verseEnd { get; set; }

    public string GetText()
    {
        if (_verseEnd != 0)
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd} says, ";
        }
        return $"{_book} {_chapter}:{_verseStart} says, ";
    }
}