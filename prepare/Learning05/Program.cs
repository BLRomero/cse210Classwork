using System;
// using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes =
        [
            new Square(4, "Blue"),
            new Square(6, "greeen"),
            new Circle(2.5, "Red"),
            new Rectangle(4, 3, "Purple"),
        ];

        foreach (Shape shape in shapes)
        {
            // string color = shape.GetColor();
            // double area = shape.GetArea();

            // Console.WriteLine($"Color: [color] Area: {area}");

            // Console.WriteLine($"Shape Color: {shape.GetColor()}");
            // Console.WriteLine($"Shape Area: {shape.GetArea()}");
            // Console.WriteLine("");

        }



        Shape shape1 = new Shape();
        shape1.SetColor("Blue");
        Console.WriteLine(shape1.GetSummary());
        Console.WriteLine("");

        Console.WriteLine("**Get Area Overiding default for square**");
        Square square1 = new Square(4, "Red");
        Console.WriteLine(square1.GetSummary());
        Console.WriteLine("");

        Console.WriteLine("**Get Area Overiding default for circle**");
        Circle circle1 = new Circle(2.5, "Yellow");
        Console.WriteLine(circle1.GetSummary());
        Console.WriteLine("");

        Console.WriteLine("**Get Area Overiding default for rectangle**");
        Rectangle rectangle1 = new Rectangle(4, 3, "Purple");
        Console.WriteLine(rectangle1.GetSummary());
        Console.WriteLine("");

    }
}