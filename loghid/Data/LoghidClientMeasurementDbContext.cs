using Microsoft.EntityFrameworkCore;
using Loghid.Models;

namespace Loghid.Data
{
    public class LoghidClientMeasurementDbContext : DbContext
    {
        public LoghidClientMeasurementDbContext(DbContextOptions<LoghidClientMeasurementDbContext> options)
            : base(options)
        {
        }

        public DbSet<ClientMeasurement> Measurements { get; set; }
        public DbSet<Substance> Substances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<ClientMeasurement>()
        .HasKey(m => m.Id_Measurement); // Clave primaria

    modelBuilder.Entity<ClientMeasurement>()
        .Property(m => m.PublicID_Measurement)
        .HasMaxLength(19) // 16 caracteres + 3 guiones
        .IsRequired()
        .ValueGeneratedOnAdd(); // Se genera al insertar, pero no cambia después

    // Definir índice único para PublicID_Measurement
    modelBuilder.Entity<ClientMeasurement>()
        .HasIndex(m => m.PublicID_Measurement)
        .IsUnique();

        modelBuilder.Entity<ClientMeasurement>()
        .Property(m => m.Date_Measurement)
        .HasDefaultValueSql("CURRENT_TIMESTAMP");
}
    }
}