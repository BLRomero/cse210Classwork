using System;

public class Comment
{
    // Properties
    private string _username;
    private string _text;
    // Constructor
    public Comment(string username, string text)
    {
        _username = username;
        _text = text;
    }

    // Override ToString method to provide a formatted string representation of a comment
    public override string ToString()
    {
        return $"{_username} ~ {_text}";
    }
}
