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
    }
}
