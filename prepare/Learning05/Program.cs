using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("Purple", 6);
        shapes.Add(shape1);

        RectangularShape shape2 = new RectangularShape("Pink", 10, 12);
        shapes.Add(shape2);

        Circle shape3 = new Circle("Yellow", 20);
        shapes.Add(shape3);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}