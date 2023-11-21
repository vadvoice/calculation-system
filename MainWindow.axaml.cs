using Avalonia;
using Avalonia.Controls;

namespace c_sharp;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void OnSubmitClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var nameInput = this.FindControl<TextBox>("NameInput");
        var ageInput = this.FindControl<TextBox>("AgeInput");

        var name = nameInput?.Text;
        var age = ageInput?.Text;

        if (name != null && age != null)
        {
            var result = $"Hello, {name}. You are {age} years old.";
            // show the result
            System.Console.WriteLine(result);
            this.FindControl<TextBlock>("ResultText").Text = result;
        }
    }

    public void OnCalculateClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var baseInput = this.FindControl<TextBox>("BaseInput");
        var heightInput = this.FindControl<TextBox>("HeightInput");

        double.TryParse(baseInput?.Text, out double baseValue);
        double.TryParse(heightInput?.Text, out double heightValue);

        if (baseValue > 0 && heightValue > 0)
        {
            var area = 0.5 * baseValue * heightValue;
            this.FindControl<TextBlock>("AreaResult").Text = $"The area of the triangle is {area}";
        }
        else
        {
            this.FindControl<TextBlock>("AreaResult").Text = "Invalid input. Please enter numbers for the base and height.";
        }
    }
}