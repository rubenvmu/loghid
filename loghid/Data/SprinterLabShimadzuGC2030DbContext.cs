using Microsoft.EntityFrameworkCore;
using Loghid.Models;

namespace Loghid.Data
{
    public class SprinterLabShimadzuGC2030DbContext : DbContext
    {
        public SprinterLabShimadzuGC2030DbContext(DbContextOptions<SprinterLabShimadzuGC2030DbContext> options)
            : base(options) { }

        public DbSet<SprinterLabShimadzuGC2030> SprinterLabs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SprinterLabShimadzuGC2030>(entity =>
            {
                entity.HasKey(e => e.Id);

                // Configurar índices para búsquedas frecuentes
                entity.HasIndex(e => e.ModeloEquipo).IsUnique();
                entity.HasIndex(e => e.NormaHidrogeno);
                entity.HasIndex(e => e.PurezaOptima);

                // Configurar valores por defecto
                entity.Property(e => e.Vehiculo).HasDefaultValue("Mercedes-Benz Sprinter");
                entity.Property(e => e.EnsayoPresion).HasDefaultValue(true);
                entity.Property(e => e.SensibilidadMinima).HasDefaultValue(0.1);
            });
        }
    }
}