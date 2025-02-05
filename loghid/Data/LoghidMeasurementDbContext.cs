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
        }
    }
}
