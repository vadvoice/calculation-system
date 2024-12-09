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
        SummaryText.Text = 
            "Вибрана конфігурація:\n\n" +
            $"{"Формула:",-25} {store.SelectedFormula}\n" +
            $"{"Параметри:",-25} {store.SelectedParameters}\n" +
            $"{"Кількість параметрів:",-25} {store.ParametersCount}\n" +
            $"{"Алгоритм:",-25} {store.SelectedAlgorithm}\n" +
            $"{"Точок на сфері:",-25} {store.PointsOnSphere}\n" +
            $"{"Точок на основі конуса:",-25} {store.PointsOnConeBase}\n" +
            $"{"Макс. кількість ітерацій:",-25} {store.MaxIterations}";
    }

    private async void OnStartClick(object? sender, RoutedEventArgs e)
    {
        var dialog = MessageBoxManager
            .GetMessageBoxStandard(
                "Зміна алгоритму",
                "Ви впевнені, що хочете розпочати розрахунок?",
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