using System;
using System.Reflection.Metadata.Ecma335;

public class Rectangle : Shapes
{
    private double _side = 0 ;

    public Rectangle(string color , int side) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}