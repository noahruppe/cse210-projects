using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;


public class Circle : Shapes
{
    private double _radius = 0;

    public Circle(string color , double radius) : base (color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius,2);
    }
}