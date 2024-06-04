using System;
using System.Collections.Generic;
using System.IO;
public class WritingAssignment : Assignment
{
    private string _title = "";


    // Default Constructor
    public WritingAssignment()
    {
        _title = "Unknown";
    }

    // Base class constructor 
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        return $"{_studentName}, - {_topic}, \n{_title}";
    }


}