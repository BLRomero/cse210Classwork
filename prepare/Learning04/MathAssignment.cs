using System;
using System.Collections.Generic;
using System.IO;
public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    // Constructor Default
    public MathAssignment()
    {
        _textbookSection = "Unknown";
        _problems = "0-0";
    }

    // base class constructor
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;

    }
    public string GetTextbookSection()
    {
        return _textbookSection;
    }
    public void SetTextbookSection(string textbookSection)
    {
        _textbookSection = textbookSection;
    }
    public string GetProblems()
    {
        return _problems;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_studentName}, - {_topic},\nSection: {_textbookSection}, Problems: {_problems}";

    }

}