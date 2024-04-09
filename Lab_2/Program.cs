using Avalonia;
using System;
using System.Collections.Generic;
using Lab_2.Models;
using Point = Lab_2.Models.Point;
using Polygon = Lab_2.Models.Polygon;

namespace Lab_2;

class Program
{
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);
    
        /*Point point = new Point(300, 400);
        Console.WriteLine("point:");
        Console.WriteLine($"X = {point.X}");
        Console.WriteLine($"Y = {point.Y}");
        Console.WriteLine($"Center = {point.Center}");
        Console.WriteLine($"Area = {point.Area()}");
        Console.WriteLine($"BoundingBox = {point.BoundingBox()}\n");

        Point p1 = new Point(300, 200);
        Point p2 = new Point(500, 600);
        
        Line line = new Line(p1,p2);
        Console.WriteLine("line:");
        Console.WriteLine($"point_start = {line.PointStart}");
        Console.WriteLine($"point_end = {line.PointEnd}");
        Console.WriteLine($"Center = {line.Center}");
        Console.WriteLine($"Area = {line.Area()}");
        Console.WriteLine($"BoundingBox = {line.BoundingBox()}\n");

        var points = new List<Point>()
        {
            new Point(4.81, 7.47),
            new Point(11.35, 7.21),
            new Point(7.67, 4.39)
        };
        
        Polygon polygon = new Polygon(points);
        Console.WriteLine("polygon:");
        Console.WriteLine($"Center = {polygon.Center}");
        Console.WriteLine($"Area = {polygon.Area()}\n");
        //Console.WriteLine($"BoundingBox = {polygon.BoundingBox()}\n");

        Ellipse ellipse = new Ellipse(point, 30, 20);
        Console.WriteLine("ellipse:");
        Console.WriteLine($"Center = {ellipse.Center}");
        Console.WriteLine($"Area = {ellipse.Area()}");
        Console.WriteLine($"BoundingBox = {ellipse.BoundingBox()}\n");*/
    
    
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace();
}