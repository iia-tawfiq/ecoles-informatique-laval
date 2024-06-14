namespace ecoles_informatiques.Models.ViewModels;

public class AdminParameterCreateViewModel
{
    public Parameter Parameter { get; set; }

    public AdminParameterCreateViewModel(Parameter parameter)
    {
        Parameter = parameter;
    }
}