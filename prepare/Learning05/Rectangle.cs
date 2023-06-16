using System;

public class RectangularShape : Shape
{
    private double _length;
    private double _width;

    public RectangularShape(string color, double length, double width) : base (color)
    {
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {
        return _length * _width;
    }
}