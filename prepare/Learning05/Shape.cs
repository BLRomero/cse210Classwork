using System;
// using System.Drawing;

public class Shape
{
    protected string _color = "";


    public Shape()
    {
        _color = "unknown";
    }

    public Shape(string color)
    {
        _color = color;

    }
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 0.0;
    }

    public string GetSummary()
    {
        return ($"Your shape color is: {_color} \nThe area of your shape is {this.GetArea()}");

    }
}