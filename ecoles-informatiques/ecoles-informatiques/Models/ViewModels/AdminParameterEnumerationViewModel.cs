namespace ecoles_informatiques.Models.ViewModels;

public class AdminParameterEnumerationViewModel
{
    public List<Parameter> Parameters { get; set; }

    public AdminParameterEnumerationViewModel(List<Parameter> parameters)
    {
        Parameters = parameters;
    }
}