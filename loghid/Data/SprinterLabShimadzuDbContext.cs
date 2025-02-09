using Microsoft.EntityFrameworkCore;
using Loghid.Models;

namespace Loghid.Data
{
    public class SprinterLabShimadzuDbContext : DbContext
    {
        public SprinterLabShimadzuDbContext(DbContextOptions<SprinterLabShimadzuDbContext> options)
            : base(options) { }

        public DbSet<SprinterLab> SprinterLab { get; set; }

        // Configuraciones personalizadas del modelo para la base de datos SQLite
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurar la clave primaria y otras relaciones si es necesario
            modelBuilder.Entity<SprinterLab>()
                .HasKey(m => m.Id);

            // Otras configuraciones específicas para SQLite, si las tienes
            // Ejemplo: Limitación del tamaño de texto para SQLite
            modelBuilder.Entity<SprinterLab>()
                .Property(m => m.Vehicle)
                .HasMaxLength(100);  // Puedes personalizar otros campos con restricciones

            // Aquí podrías agregar más configuraciones si tienes restricciones específicas
        }
    }
}