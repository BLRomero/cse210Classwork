using System;

public class Comment
{
    private string _username;
    private string _text;
    public Comment(string username, string text)
    {
        _username = username;
        _text = text;
    }
    public override string ToString()
    {
        return $"{_username} ~ {_text}";
    }
}
