namespace ecoles_informatiques.Models.ViewModels;

public class AdminSchoolCreateViewModel
{
    public School School { get; set; }

    public AdminSchoolCreateViewModel(School school)
    {
        School = school;
    }
}