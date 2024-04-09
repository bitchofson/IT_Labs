using System;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Lab_2.ViewModels;

namespace Lab_2;

public partial class MainWindow : Window
{
    private readonly MainWindowViewModel _mainWindowViewModel;
    public MainWindow()
    {
        InitializeComponent();
        _mainWindowViewModel = new MainWindowViewModel();
    }
    
    private void PointerPressedHandler (object sender, PointerPressedEventArgs args)
    {
        var point = args.GetCurrentPoint(this);
        points.Text = _mainWindowViewModel.PointerMsg(point: point);
    }

    private void ClearHandler(object? sender, RoutedEventArgs e)
    {
        _mainWindowViewModel.ClearPoints();
        points.Text = "[ ]";
        characteristics.Text = "";
    }

    private void Draw(object? sender, RoutedEventArgs e)
    {
        characteristics.Text = _mainWindowViewModel.Characteristics();
    }
}