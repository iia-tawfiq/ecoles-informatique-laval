using ecoles_informatiques.Models;

namespace ecoles_informatiques.Models
{
    public class DiplomasViewModel
    {
        public List<Diploma> Diplomas { get; set; }

        public DiplomasViewModel(List<Diploma> diplomas)
        {
            Diplomas = diplomas;
        }
    }

}