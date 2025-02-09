using Microsoft.EntityFrameworkCore;
using Loghid.Models;

namespace Loghid.Data
{
    public class SprinterLabShimadzuGC2030DbContext(DbContextOptions<SprinterLabShimadzuGC2030DbContext> options) : DbContext(options)
    {
        public DbSet<SprinterLabShimadzuGC2030> SprinterLabs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SprinterLabShimadzuGC2030>(entity =>
            {
                entity.HasKey(e => e.Id);

            });
        }
    }
}