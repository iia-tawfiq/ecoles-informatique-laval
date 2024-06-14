using ecoles_informatiques.Models;

namespace ecoles_informatiques.Models
{
    public class DiplomaViewModel
    {
        public List<Diploma> Diplomas { get; set; }
        public DiplomaViewModel(List<Diploma> diplomas)
        {
            Diplomas = diplomas;
        }
    }

}
