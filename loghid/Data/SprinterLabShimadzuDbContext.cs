using Microsoft.EntityFrameworkCore;
using Loghid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loghid.Data
{
    public class SprinterLabShimadzuDbContext : DbContext
    {
        public SprinterLabShimadzuDbContext(DbContextOptions<SprinterLabShimadzuDbContext> options) 
            : base(options) { }

        public DbSet<SprinterLab> SprinterLab { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<SprinterLab>()
                .HasKey(m => m.Id); 
        }
    }
}