using System;
using System.Reflection.Metadata.Ecma335;

public class Circle : Shape
{
 private double _radius;
    // base class constructor
    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }


    public override double GetArea()
    {
        return Math.PI * _radius* _radius;
    }


}