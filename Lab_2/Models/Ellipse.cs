using System;

namespace Lab_2.Models;

public class Ellipse(Point center, double radius1, double radius2)
    : Shape(center.X, center.Y)
{

    public override double Area() => Math.PI * radius1 * radius2;

    public override (double width, double height) BoundingBox()
    {
        /*double minX = _x - radius1;
        double minY = _y - radius2;
        double maxX = _x + radius1;
        double maxY = _y + radius2;
        return (minX, minY, maxX, maxY);*/
        throw new System.NotImplementedException();
    }
    
    public override string BaseInformation()
    {
        return "Point(Center: " + Center + " Area: " + Area() + " )";
    }
}