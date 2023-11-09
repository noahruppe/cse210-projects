using System;
using System.Collections.Generic;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("green",4);
        string color = square.GetColor();
        double number =square.GetArea();
        Console.WriteLine($"the color of the square is {color} and the area is {number}");

        Rectangle rectangle = new Rectangle("blue",10);
        string color1 = rectangle.GetColor();
        double number1 = rectangle.GetArea();
        Console.WriteLine($"the color is {color1} and the area is {number1}");


        Circle circle = new Circle("red",23.4);
        string color2 = circle.GetColor();
        double number2 = circle.GetArea();

        Console.WriteLine($"the color is {color2} and the area is {number2}");

        List<Shapes> shapes = new List<Shapes>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shapes shapes1 in shapes)
        {
            double theshape = shapes1.GetArea();
            Console.WriteLine(theshape);
        }



        


        
    }
}

