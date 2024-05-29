using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructor to initialize the reference
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1;
    }

    public Reference(string book, int chapter, int verse, int endVerse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
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

    public int GetEndVerse(){
        return _endVerse;
    }

    // Override ToString method to return the formatted reference
    public override string ToString()
    {
        if (_endVerse == -1){
             return $"{_book} {_chapter}:{_verse}";
        }
        else{
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
       
    }
}
