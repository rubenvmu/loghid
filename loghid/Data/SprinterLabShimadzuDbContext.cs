using Microsoft.EntityFrameworkCore;
using Loghid.Models;

namespace Loghid.Data
{
    public class SprinterLabShimadzuDbContext(DbContextOptions<SprinterLabShimadzuDbContext> options) : DbContext(options)
    {
        public DbSet<SprinterLab> SprinterLab { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<SprinterLab>()
                .ToTable("SprinterLab")  
                .HasKey(s => s.Id);  

        }
    }
}