using System;

namespace Lab_2.Models;

public class Point(double x, double y) : Shape(x, y)
{
    public double X
    {
        get => _x;
    }
    public double Y
    {
        get => _y;
    }

    public override double Area() => 0;

    public override (double width, double height) BoundingBox()
    {
        minX = Math.Min(minX, X);
        maxX = Math.Max(maxX, X);
        minY = Math.Min(minY, Y);
        maxY = Math.Max(maxY, Y);

        double width = maxX - minX;
        double height = maxY - minY;

        return (width, height);
    }

    public override string BaseInformation()
    {
        return "Point(Center: " + Center + " Area: " + Area() + " BoundingBox: " + BoundingBox() + " )";
    }

    public override int GetHashCode()
    {
        int prime = 31;
        return prime + prime * (int) x + prime * prime * (int) y;
    }

    public override bool Equals(object? obj)
    {
        var item = obj as Point;
        
        if (item == null) return false;
        
        return X.Equals(item.X) && Y.Equals(item.Y);
    }

    public override string ToString()
    {
        return String.Format($"({X}, {Y})");
    }
}