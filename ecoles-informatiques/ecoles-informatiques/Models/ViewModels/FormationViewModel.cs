namespace ecoles_informatiques.Models.ViewModels
{
    public class FormationViewModel

    {
        public Formation Formation { get; set; }
        public School School { get; set; }

        public FormationViewModel(Formation formation, School school)
        {
            Formation = formation;
            School = school;
        }


    }
}
