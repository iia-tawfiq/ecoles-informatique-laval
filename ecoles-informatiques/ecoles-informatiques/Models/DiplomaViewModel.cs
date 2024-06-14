namespace ecoles_informatiques.Models
{
    public class DiplomaViewModel
    {
        public List<Formation> Formations { get; set; }
        public DiplomaViewModel(List<Formation> formations)
        {
            Formations = formations;
        }
        public Diploma Diplomas { get; set; }
        public DiplomaViewModel(Diploma diplomas)
        {
            Diplomas = diplomas;
        }
        
    }
    
}
