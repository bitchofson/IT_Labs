namespace Lab_2.Models;

public abstract class Shape(double x, double y)
{
    protected double _x = x; // Координата X центра фигуры
    protected double _y = y; // Координата Y центра фигуры
    
    protected double minX = double.MaxValue;
    protected double maxX = -double.MaxValue;
    protected double minY = double.MaxValue;
    protected double maxY = -double.MaxValue;

    public (double _x, double _y) Center => (_x, _y);
    public abstract double Area();
    
    public abstract (double width, double height) BoundingBox();

    public abstract string BaseInformation();
}