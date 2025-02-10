using Microsoft.EntityFrameworkCore;
using Loghid.Models;

namespace Loghid.Data
{
    public class eSprinterLabShimadzuDbContext : DbContext
    {
        public eSprinterLabShimadzuDbContext(DbContextOptions<eSprinterLabShimadzuDbContext> options)
            : base(options) { }

        public DbSet<eSprinterLab> eSprinterLab { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        
            modelBuilder.Entity<eSprinterLab>()
                .HasKey(m => m.Id);


        }
    }
}