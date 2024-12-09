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
    public string? SelectedParameters { get; set; }
    public int ParametersCount { get; set; }
    public int IterationsCount { get; set; }
  
    // step 2
    public string? SelectedAlgorithm { get; set; }
    public int InitialStepSize { get; set; }
    public int MinStepSize { get; set; }
    public int InitialAngle { get; set; }
    public int PointsOnSphere { get; set; }
    public int PointsOnConeBase { get; set; }
    public int MaxIterations { get; set; }
} 