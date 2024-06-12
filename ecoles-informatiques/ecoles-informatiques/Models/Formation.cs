﻿namespace ecoles_informatiques.Models
{
    public class Formation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public bool StudentStatus { get; set; }
        public bool ApprenticeshipStatus { get; set; }

        public School School { get; set; }
        public GradeLevel MinimumGrade { get; set;}
        
        public Diploma Diploma { get; set; }
    }
}
