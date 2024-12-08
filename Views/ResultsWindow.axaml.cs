using Avalonia.Controls;
using Avalonia.Interactivity;

namespace c_sharp.Views;

public partial class ResultsWindow : Window
{
    public ResultsWindow()
    {
        InitializeComponent();
    }

    private void OnNewCalculationClick(object? sender, RoutedEventArgs e)
    {
        var step1 = new Step1Window();
        step1.Show();
        this.Close();
    }
} 