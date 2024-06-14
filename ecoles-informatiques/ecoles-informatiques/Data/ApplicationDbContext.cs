using ecoles_informatiques.Models;
using Microsoft.AspNetCore.Identity;
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
        public DbSet<Parameter> Parameters { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Grade Levels
			modelBuilder.Entity<GradeLevel>().HasData(
				new GradeLevel { Id = 1, ShortLabel = "Bac", LongLabel = "Baccalauréat" },
				new GradeLevel { Id = 2, ShortLabel = "Bac+2", LongLabel = "Diplôme de niveau Bac+2" },
				new GradeLevel { Id = 3, ShortLabel = "Bac+3", LongLabel = "Diplôme de niveau Bac+3" },
				new GradeLevel { Id = 4, ShortLabel = "Bac+5", LongLabel = "Diplôme de niveau Bac+5" }
			);

			// Diplomas
			modelBuilder.Entity<Diploma>().HasData(
				new Diploma { Id = 1, Name = "Diplôme d'ingénieur", GradeLevelId = 4 },
				new Diploma { Id = 2, Name = "Master", GradeLevelId = 4 },
				new Diploma { Id = 3, Name = "Licence", GradeLevelId = 3 },
				new Diploma { Id = 4, Name = "BTS", GradeLevelId = 2 },
				new Diploma { Id = 5, Name = "IUT", GradeLevelId = 2 }
			);

			// Schools
			modelBuilder.Entity<School>().HasData(
				new School { Id = 1, Name = "ESIEA Laval", Address = "38 Rue des Drs Calmette et Guérin", City = "Laval", Description = "École d'ingénieurs spécialisée en numérique et cybersécurité", Slug = "esiea-laval" },
				new School { Id = 2, Name = "ESUP Laval", Address = "123 Rue de Bretagne", City = "Laval", Description = "École de commerce offrant des BTS et des Bachelors", Slug = "esup-laval" },
				new School { Id = 3, Name = "IUT Laval", Address = "52 Rue des Docteurs Calmette", City = "Laval", Description = "Institut Universitaire de Technologie", Slug = "iut-laval" },
				new School { Id = 4, Name = "Lycée Douanier Rousseau", Address = "14 Rue de l'Alma", City = "Laval", Description = "Lycée général et technologique", Slug = "lycee-douanier-rousseau" },
				new School { Id = 5, Name = "Lycée Réaumur", Address = "28 Rue des Déportés", City = "Laval", Description = "Lycée proposant des formations professionnelles et technologiques", Slug = "lycee-reaumur" },
				new School { Id = 6, Name = "IIA Laval", Address = "5 Boulevard de l'Industrie, Saint-Berthevin", City = "Laval", Description = "Institut d'Informatique Appliquée spécialisé en informatique et numérique", Slug = "iia-laval" }
			);

			// Formations
			modelBuilder.Entity<Formation>().HasData(
				new Formation
				{
					Id = 1,
					Name = "Ingénierie en Cybersécurité",
					Price = 5000,
					Description = "Formation en cybersécurité avec spécialisation en systèmes embarqués.",
					Slug = "ingenierie-cybersecurite",
					StudentStatus = true,
					ApprenticeshipStatus = true,
					SchoolId = 1,
					GradeLevelId = 4,
					DiplomaId = 1
				},
				new Formation
				{
					Id = 2,
					Name = "Bachelor en Informatique",
					Price = 3500,
					Description = "Programme de Bachelor avec des spécialisations en développement logiciel et data science.",
					Slug = "bachelor-informatique",
					StudentStatus = true,
					ApprenticeshipStatus = false,
					SchoolId = 2,
					GradeLevelId = 3,
					DiplomaId = 3
				},
				new Formation
				{
					Id = 3,
					Name = "DUT Informatique",
					Price = 0,
					Description = "Diplôme Universitaire de Technologie en informatique avec une option en réseaux et télécommunications.",
					Slug = "dut-informatique",
					StudentStatus = true,
					ApprenticeshipStatus = true,
					SchoolId = 3,
					GradeLevelId = 2,
					DiplomaId = 5
				},
				new Formation
				{
					Id = 4,
					Name = "BTS Services Informatiques aux Organisations",
					Price = 0,
					Description = "Brevet de Technicien Supérieur en services informatiques aux organisations.",
					Slug = "bts-sio",
					StudentStatus = true,
					ApprenticeshipStatus = true,
					SchoolId = 4,
					GradeLevelId = 2,
					DiplomaId = 4
				},
				new Formation
				{
					Id = 5,
					Name = "Licence Professionnelle en Informatique",
					Price = 0,
					Description = "Licence professionnelle avec des cours avancés en gestion des systèmes d'information.",
					Slug = "licence-pro-informatique",
					StudentStatus = true,
					ApprenticeshipStatus = true,
					SchoolId = 5,
					GradeLevelId = 3,
					DiplomaId = 3
				},
				new Formation
				{
					Id = 6,
					Name = "Développeur Web et Web Mobile",
					Price = 5200,
					Description = "Formation pour devenir développeur web et web mobile, incluant des compétences en front-end et back-end.",
					Slug = "dev-web-mobile",
					StudentStatus = true,
					ApprenticeshipStatus = true,
					SchoolId = 6,
					GradeLevelId = 2,
					DiplomaId = 4
				},
				new Formation
				{
					Id = 7,
					Name = "Manager Cybersécurité",
					Price = 7500,
					Description = "Formation de manager en cybersécurité pour acquérir des compétences avancées en protection des systèmes d'information.",
					Slug = "manager-cybersecurite",
					StudentStatus = true,
					ApprenticeshipStatus = true,
					SchoolId = 6,
					GradeLevelId = 4,
					DiplomaId = 2
				}
			);

			// Users
			var hasher = new PasswordHasher<IdentityUser>();

			modelBuilder.Entity<IdentityUser>().HasData(
				new IdentityUser
				{
					Id = "60fb5145-7fa7-4e07-af4d-323a8cb19b39",
					UserName = "admin",
					NormalizedUserName = "ADMIN@EXAMPLE.COM",
					Email = "admin@example.com",
					NormalizedEmail = "ADMIN@EXAMPLE.COM",
					EmailConfirmed = true,
					//PasswordHash = hasher.HashPassword(null, "Testtest9*"),
					PasswordHash = "AQAAAAIAAYagAAAAEPk+QzkkQL9UCTnt7ytQhAwrqcZtuXn//4ew15/RNW1GhploP4Q27tA/K1W6UlPjoA==",
					ConcurrencyStamp = "f566d4f1-71db-4e1d-9d2f-0687c115a3bd",
					SecurityStamp = "OECJYRXF22Y64JSHS5RWDF2M7GYBQE6G",
				},
				new IdentityUser
				{
					Id = "6250adfa-eb23-455b-aea7-494361b7f13f",
					UserName = "test@test.com",
					NormalizedUserName = "TEST@TEST.COM",
					Email = "test@test.com",
					NormalizedEmail = "TEST@TEST.COM",
					EmailConfirmed = true,
					//PasswordHash = hasher.HashPassword(null, "Testtest9*"),
					PasswordHash = "AQAAAAIAAYagAAAAEEXOY9AhrU7GlpjYz2sEqlCIKzTATb6ljJRGtM/ZPAuzZScicbu6WbyyuNUl7gyCPQ==",
					ConcurrencyStamp = "be3506fd-2240-41aa-83fa-5ff71692e6e7",
					SecurityStamp = "RVWKTAEQWZLJUJXFHCXUHCQIDDWW27FQ"
				}
			);

			modelBuilder.Entity<IdentityRole>().HasData(
				new IdentityRole
				{
					Id = "1",
					Name = "Admin",
					NormalizedName = "ADMIN"
				},
				new IdentityRole
				{
					Id = "2",
					Name = "User",
					NormalizedName = "USER"
				}
			);

			modelBuilder.Entity<IdentityUserRole<string>>().HasData(
				new IdentityUserRole<string>
				{
					UserId = "60fb5145-7fa7-4e07-af4d-323a8cb19b39",
					RoleId = "1"
				},
				new IdentityUserRole<string>
				{
					UserId = "6250adfa-eb23-455b-aea7-494361b7f13f",
					RoleId = "2"
				}
			);
		}


	}
}