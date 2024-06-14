namespace ecoles_informatiques.Models.ViewModels;

public class AdminParameterEditViewModel
{
    public Parameter Parameter { get; set; }

    public AdminParameterEditViewModel(Parameter parameter)
    {
        Parameter = parameter;
    }
}