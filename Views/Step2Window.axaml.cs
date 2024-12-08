using Avalonia.Controls;
using Avalonia.Interactivity;
using c_sharp.Store;

namespace c_sharp.Views;

public partial class Step2Window : Window
{
    public Step2Window()
    {
        InitializeComponent();
    }

    private void OnNextClick(object? sender, RoutedEventArgs e)
    {
        var store = CalculationStore.Instance;
        store.SelectedAlgorithm = (AlgorithmComboBox.SelectedItem as ComboBoxItem)?.Content?.ToString();
        store.PointsCount = (int)PointsInput.Value;
        store.MinNumber = (int)MinNumberInput.Value;

        var step3 = new Step3Window();
        step3.Show();
        this.Close();
    }
} 