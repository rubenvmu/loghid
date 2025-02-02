using Microsoft.EntityFrameworkCore;
using loghid.Models;

namespace loghid.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor requerido para DI
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Elimina el método OnConfiguring si ya existe
        public DbSet<IdealParameter> IdealParameters { get; set; }
        public DbSet<ContaminantParameter> ContaminantParameters { get; set; }
    }
}