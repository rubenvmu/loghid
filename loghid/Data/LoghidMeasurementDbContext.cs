using Microsoft.EntityFrameworkCore;
using Loghid.Models;

namespace Loghid.Data
{
    public class LoghidClientMeasurementDbContext(DbContextOptions<LoghidClientMeasurementDbContext> options) : DbContext(options)
    {
        public DbSet<ClientMeasurement> Measurements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
