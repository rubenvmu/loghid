using Microsoft.EntityFrameworkCore;
using loghid.Models;

namespace loghid.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<IdealParameter> IdealParameters { get; set; }
        public DbSet<ContaminantParameter> ContaminantParameters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=loghid.db");
        }
    }
}