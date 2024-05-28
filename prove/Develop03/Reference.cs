using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;

    // Constructor to initialize the reference
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    // Method to get the book
    public string GetBook()
    {
        return _book;
    }

    // Method to get the chapter
    public int GetChapter()
    {
        return _chapter;
    }

    // Method to get the verse
    public int GetVerse()
    {
        return _verse;
    }

    // Override ToString method to return the formatted reference
    public override string ToString()
    {
        return $"{_book} {_chapter}:{_verse}";
    }
}
