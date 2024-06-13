namespace ecoles_informatiques.Models.ViewModels;

public class AdminSchoolEnumerationViewModel
{
    public List<School> Schools { get; set; }

    public AdminSchoolEnumerationViewModel(List<School> schools)
    {
        Schools = schools;
    }
}