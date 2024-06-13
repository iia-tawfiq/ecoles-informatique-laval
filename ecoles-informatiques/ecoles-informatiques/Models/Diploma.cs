namespace ecoles_informatiques.Models
{
    public class Diploma
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public GradeLevel Gradelevels { get; set; }
        public int GradeLevelId { get; set;}
    }
}
