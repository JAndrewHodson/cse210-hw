using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Shape square = new Square("blue", 8);
        Shape circle = new Circle("green", 4);
        Shape rectangle = new Rectangle("red", 5, 4);

        List<Shape> shapes = new List<Shape>();

        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rectangle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape takes up {area} square units of space");
        }

    }
}