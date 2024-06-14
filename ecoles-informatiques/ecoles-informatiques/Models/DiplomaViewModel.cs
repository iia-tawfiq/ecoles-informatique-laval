namespace ecoles_informatiques.Models
{
    public class DiplomaViewModel
    {
        public List<Formation> Formations { get; set; }
        public Diploma Diplomas { get; set; }
        public DiplomaViewModel(List<Formation> formations, Diploma diplomas)
        {
            Formations = formations;
            Diplomas = diplomas;
        }

    }

}
