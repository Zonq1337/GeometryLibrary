using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

// Circle.cs
public class Circle
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be positive");
        _radius = radius;
    }

    public double Area() => Math.Round(Math.PI * _radius * _radius, 5);
    public double Perimeter() => Math.Round(2 * Math.PI * _radius, 5);
}

// Square.cs
public class Square
{
    private readonly double _side;

    public Square(double side)
    {
        if (side <= 0)
            throw new ArgumentException("Side must be positive");
        _side = side;
    }

    public double Area() => _side * _side;
    public double Perimeter() => 4 * _side;
}