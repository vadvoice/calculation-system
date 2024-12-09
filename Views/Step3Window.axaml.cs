using Avalonia.Controls;
using Avalonia.Interactivity;
using c_sharp.Store;

namespace c_sharp.Views;

public partial class Step3Window : Window
{
    public Step3Window()
    {
        InitializeComponent();
        LoadSummary();
    }

    private void LoadSummary()
    {
        var store = CalculationStore.Instance;
        SummaryText.Text = "Selected Configuration:\n\n" +
            $"Formula: {store.SelectedFormula}\n" +
            $"Parameters Count: {store.ParametersCount}\n" +
            $"Algorithm: {store.SelectedAlgorithm}\n" +
            $"Points on Sphere: {store.PointsOnSphere}\n" +
            $"Points on Cone Base: {store.PointsOnConeBase}\n" +
            $"Max Iterations: {store.MaxIterations}";
    }

    private void OnStartClick(object? sender, RoutedEventArgs e)
    {
        var resultsWindow = new ResultsWindow();
        resultsWindow.Show();
        this.Close();
    }
} 