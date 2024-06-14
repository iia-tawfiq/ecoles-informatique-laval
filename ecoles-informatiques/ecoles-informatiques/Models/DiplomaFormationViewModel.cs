namespace ecoles_informatiques.Models
{
    public class DiplomaFormationViewModel
    {
        public List<Formation> Formations { get; set; }
        public DiplomaFormationViewModel(List<Formation> formations)
        {
            Formations = formations;
        }
    }
    
}
