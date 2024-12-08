namespace c_sharp.Store;

public class CalculationStore
{
    private static CalculationStore? _instance;
    
    public static CalculationStore Instance
    {
        get
        {
            _instance ??= new CalculationStore();
            return _instance;
        }
    }

    public string? SelectedFormula { get; set; }
    public int ParametersCount { get; set; }
    public string? SelectedAlgorithm { get; set; }
    public int PointsCount { get; set; }
    public int MinNumber { get; set; }
} 