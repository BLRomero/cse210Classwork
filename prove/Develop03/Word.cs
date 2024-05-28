using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor to initialize the word
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Method to get the text of the word
    public string GetText()
    {
        return _text;
    }

    // Method to hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Method to show the word
    public void Show()
    {
        _isHidden = false;
    }

    // Override ToString method to return the word text, respecting the hidden state
    public override string ToString()
    {
        if (_isHidden)
        {
            return "____"; // or any representation of a hidden word
        }
        return _text;
    }
}
