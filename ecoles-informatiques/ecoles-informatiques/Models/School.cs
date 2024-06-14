using NetTopologySuite.Geometries;

namespace ecoles_informatiques.Models
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public string Description { get; set; }
        public string Slug { get; set; }
        //       public Coordinate Location { get; set; }

        public List<Formation> Formations { get; set; }
    }
}
