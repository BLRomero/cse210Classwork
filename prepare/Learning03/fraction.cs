using System;


public class Fraction  //creating the fraction class
{

    private int _top;
    private int _bottom;

    public Fraction() //constructor
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int WholeNumber) //constructor
    {
        _top = WholeNumber;
        _bottom = 5;
    }

    public Fraction(int top, int bottom) //constructor
    {
        _top =top;
        _bottom = bottom;
    }

    public string GetFractionString() 
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;

    }
}