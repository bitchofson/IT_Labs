using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia.Input;
using Lab_2.Models;

namespace Lab_2.ViewModels;

public class MainWindowViewModel
{
    private HashSet<Point> _points;

    public MainWindowViewModel()
    {
        _points = new HashSet<Point>();
    }
    
    public string? PointerMsg (PointerPoint point)
    {
        var x = point.Position.X;
        var y = point.Position.Y;
        
        
        _points.Add(new Point(x: x, y: y));
        
        string result = "[ ";
        foreach (var p in _points)
        {
            result += p + ", ";
        }
        result += " ]";
                
        return result;
    }

    public void ClearPoints()
    {
        _points.Clear();
    }

    public string? Characteristics()
    {
        return Convert.ToString(_points.Count switch
        {
            1 => _points.First().BaseInformation(),
            2 => new Line(_points.First(), _points.Last()).BaseInformation(),
            _ => ""
        });
    }
}