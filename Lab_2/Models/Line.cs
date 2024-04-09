using System;

namespace Lab_2.Models;

public class Line(Point pointStart, Point pointEnd)
    : Shape((pointStart.X + pointEnd.X) / 2.0, (pointStart.Y + pointEnd.Y) / 2.0)
{

    public new (double x, double y) Center => ((PointStart.X + PointEnd.X) / 2.0, (PointStart.Y + PointEnd.Y) / 2.0);

    public Point PointStart
    {
        get;
        set;
    } = pointStart;

    public Point PointEnd
    {
        get;
    } = pointEnd;
    
    public override double Area() => 0;

    public override (double width, double height) BoundingBox()
    {
        double minX = Math.Min(this.minX, PointStart.X);
        double minY = Math.Min(this.minY, PointStart.Y);
        double maxX = Math.Max(this.maxX, PointEnd.X);
        double maxY = Math.Max(this.maxY, PointEnd.Y);
        
        double width = maxX - minX;
        double height = maxY - minY;
        
        return (width, height);
    }
    
    public override string BaseInformation()
    {
        return "Line(Center: " + Center + " Area: " + Area() + " BoundingBox: " + BoundingBox() + " )";
    }
}