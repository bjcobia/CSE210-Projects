using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Square newSquare = new Square("blue", 5);
        Circle newCircle = new Circle("red", 3);
        Rectangle newRectangle = new Rectangle("green", 4, 5);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(newSquare);
        shapes.Add(newCircle);
        shapes.Add(newRectangle);

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {area}");
        }
    }
}