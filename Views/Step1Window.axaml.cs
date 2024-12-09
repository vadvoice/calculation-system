using Avalonia.Controls;
using Avalonia.Interactivity;
using c_sharp.Store;

namespace c_sharp.Views;

public partial class Step1Window : Window
{
    public Step1Window()
    {
        InitializeComponent();
    }

    private void OnNextClick(object? sender, RoutedEventArgs e)
    {
        var store = CalculationStore.Instance;
        store.SelectedFormula = (FormulaComboBox.SelectedItem as ComboBoxItem)?.Content?.ToString();
        store.SelectedParameters = (ParametersComboBox.SelectedItem as ComboBoxItem)?.Content?.ToString();
        store.ParametersCount = (int)ParametersCount.Value;
        store.IterationsCount = (int)IterationsCount.Value;

        var step2 = new Step2Window();
        step2.Show();
        this.Close();
    }
} 