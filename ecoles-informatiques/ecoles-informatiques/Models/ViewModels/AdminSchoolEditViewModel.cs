namespace ecoles_informatiques.Models.ViewModels;

public class AdminSchoolEditViewModel
{
    public School? School { get; set; }

    public AdminSchoolEditViewModel(School? school)
    {
        School = school;
    }
}