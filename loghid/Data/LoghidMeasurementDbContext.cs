using Microsoft.EntityFrameworkCore;
using Loghid.Models;

namespace LoghidMeasurement.Models
{
    public class LoghidMeasurementDbContext : DbContext
    {
        public DbSet<Measurement> Measurements { get; set; }

        public LoghidMeasurementDbContext(DbContextOptions<LoghidMeasurementDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración de relaciones y restricciones adicionales si es necesario
            modelBuilder.Entity<Measurement>()
                .HasOne(m => m.Substance)
                .WithMany(s => s.Measurements) // Configura la relación con Substances
                .HasForeignKey(m => m.SubstanceId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
