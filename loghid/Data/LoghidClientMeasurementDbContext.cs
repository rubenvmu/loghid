using Microsoft.EntityFrameworkCore;
using Loghid.Models;

namespace Loghid.Data
{
    public class LoghidClientMeasurementDbContext(DbContextOptions<LoghidClientMeasurementDbContext> options) : DbContext(options)
    {
        public DbSet<ClientMeasurement> Measurements { get; set; }
        public DbSet<Substance> Substances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<ClientMeasurement>()
        .HasKey(m => m.Id_Measurement); // Clave primaria real (int)

    modelBuilder.Entity<ClientMeasurement>()
        .Property(m => m.PublicID_Measurement)
        .HasMaxLength(19) // 16 caracteres + 3 guiones
        .IsRequired(); // Asegurar que no sea nulo
}

}

}