using ecoles_informatiques.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace ecoles_informatiques.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<School> Schools { get; set; }
        public DbSet<Formation> Formations { get; set; }
        public DbSet<GradeLevel> GradeLevels { get; set; }
        public DbSet<Diploma> Diplomas { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<GradeLevel>().HasData(
				new GradeLevel { Id = 1, ShortLabel = "Bac", LongLabel = "Baccalauréat" },
				new GradeLevel { Id = 2, ShortLabel = "Bac+2", LongLabel = "Diplôme de niveau Bac+2" },
				new GradeLevel { Id = 3, ShortLabel = "Bac+3", LongLabel = "Diplôme de niveau Bac+3" },
				new GradeLevel { Id = 4, ShortLabel = "Bac+5", LongLabel = "Diplôme de niveau Bac+5" }
			);

			modelBuilder.Entity<Diploma>().HasData(
				new Diploma { Id = 1, Name = "Diplôme d'ingénieur" },
				new Diploma { Id = 2, Name = "Master" },
				new Diploma { Id = 3, Name = "Licence" },
				new Diploma { Id = 4, Name = "BTS" },
				new Diploma { Id = 5, Name = "IUT" }
			);

			modelBuilder.Entity<School>().HasData(
				new School { Id = 1, Name = "School A", Address = "Address A", Description = "Description A", Slug = "school-a" },
				new School { Id = 2, Name = "School B", Address = "Address B", Description = "Description B", Slug = "school-b" },
				new School { Id = 3, Name = "School C", Address = "Address C", Description = "Description C", Slug = "school-c" },
				new School { Id = 4, Name = "School D", Address = "Address D", Description = "Description D", Slug = "school-d" },
				new School { Id = 5, Name = "School E", Address = "Address E", Description = "Description E", Slug = "school-e" }
			);

			modelBuilder.Entity<Formation>().HasData(
				new Formation
				{
					Id = 1,
					Name = "Formation A",
					Price = 1000,
					Description = "Description A",
					Slug = "formation-a",
					StudentStatus = true,
					ApprenticeshipStatus = false,
					SchoolId = 1,
					GradeLevelId = 1,
					DiplomaId = 1
				},
				new Formation
				{
					Id = 2,
					Name = "Formation B",
					Price = 2000,
					Description = "Description B",
					Slug = "formation-b",
					StudentStatus = true,
					ApprenticeshipStatus = true,
					SchoolId = 2,
					GradeLevelId = 2,
					DiplomaId = 2
				},
				new Formation
				{
					Id = 3,
					Name = "Formation C",
					Price = 3000,
					Description = "Description C",
					Slug = "formation-c",
					StudentStatus = false,
					ApprenticeshipStatus = true,
					SchoolId = 3,
					GradeLevelId = 3,
					DiplomaId = 3
				},
				new Formation
				{
					Id = 4,
					Name = "Formation D",
					Price = 4000,
					Description = "Description D",
					Slug = "formation-d",
					StudentStatus = true,
					ApprenticeshipStatus = false,
					SchoolId = 4,
					GradeLevelId = 4,
					DiplomaId = 4
				},
				new Formation
				{
					Id = 5,
					Name = "Formation E",
					Price = 5000,
					Description = "Description E",
					Slug = "formation-e",
					StudentStatus = false,
					ApprenticeshipStatus = false,
					SchoolId = 5,
					GradeLevelId = 1,
					DiplomaId = 5
				},
				new Formation
				{
					Id = 6,
					Name = "Formation F",
					Price = 1500,
					Description = "Description F",
					Slug = "formation-f",
					StudentStatus = true,
					ApprenticeshipStatus = true,
					SchoolId = 1,
					GradeLevelId = 2,
					DiplomaId = 3
				},
				new Formation
				{
					Id = 7,
					Name = "Formation G",
					Price = 2500,
					Description = "Description G",
					Slug = "formation-g",
					StudentStatus = false,
					ApprenticeshipStatus = true,
					SchoolId = 2,
					GradeLevelId = 3,
					DiplomaId = 4
				}
			);
		}

	}
}
