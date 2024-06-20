using System;
using System.Reflection.Metadata.Ecma335;

public class Square : Shape
{
 private int _side;
    // base class constructor
    public Square(int side, string color) : base(color)
    {
        _side = side;
    }

    public int GetSide()
    {
        return _side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }






}