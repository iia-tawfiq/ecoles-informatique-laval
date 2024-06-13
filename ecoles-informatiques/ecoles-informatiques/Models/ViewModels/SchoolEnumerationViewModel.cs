namespace ecoles_informatiques.Models.ViewModels;

public class SchoolEnumerationViewModel
{
    public List<School> Schools { get; set; }

    public SchoolEnumerationViewModel(List<School> schools)
    {
        Schools = schools;
    }
}