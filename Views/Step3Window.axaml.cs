using Avalonia.Controls;
using Avalonia.Interactivity;
using c_sharp.Store;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;

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
            $"Points on Cone Base:s {store.PointsOnConeBase}\n" +
            $"Max Iterations: {store.MaxIterations}";
    }

    private async void OnStartClick(object? sender, RoutedEventArgs e)
    {
        var dialog = MessageBoxManager
            .GetMessageBoxStandard(
                "Confirm Calculation",
                "Are you sure you want to start the calculation?",
                ButtonEnum.YesNo);

        var result = await dialog.ShowAsync();
        if (result == ButtonResult.Yes)
        {
            var resultsWindow = new ResultsWindow();
            resultsWindow.Show();
            this.Close();
        }
    }
} 