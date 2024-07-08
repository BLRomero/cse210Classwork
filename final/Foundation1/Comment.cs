using System;

public class Comment
{
    // Properties
    public string Username { get; set; }
    public string Text { get; set; }

    // Constructor
    public Comment(string username, string text)
    {
        Username = username;
        Text = text;
    }

    // Override ToString method to provide a formatted string representation of a comment
    public override string ToString()
    {
        return $"{Username} ~ {Text}";
    }
}
