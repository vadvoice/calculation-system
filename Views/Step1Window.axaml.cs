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
        var selectedFormula = FormulaComboBox.SelectedItem as ComboBoxItem;
        store.SelectedFormula = selectedFormula?.Content?.ToString();

        var selectedParameters = ParametersComboBox.SelectedItem as ComboBoxItem;
        store.SelectedParameters = selectedParameters?.Content?.ToString();

        store.ParametersCount = (int)ParametersCount.Value;
        store.IterationsCount = (int)IterationsCount.Value;

        var step2 = new Step2Window();
        step2.Show();
        this.Close();
    }
} 