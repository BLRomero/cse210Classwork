using System;
using System.Reflection.Metadata.Ecma335;

public class Rectangle : Shape
{
    private int _width;
    private int _height;
    // base class constructor
    public Rectangle(int width, int height, string color) : base(color)
    {
        _width = width;
        _height = height;
    }

    public int GetWidth()
    {
        return _width;
    }
    public int GetHeight(){
        return _height;
    }

    public override double GetArea()
    {
        return _width * _height;
    }






}