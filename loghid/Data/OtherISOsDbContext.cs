using Microsoft.EntityFrameworkCore;
using Loghid.Models;
using System;

namespace Loghid.data
{
    public class OtherISOsDbContext : DbContext
    {
        public OtherISOsDbContext(DbContextOptions<OtherISOsDbContext> options)
            : base(options)
        {
        }

        public DbSet<ISO21087> ISO21087s { get; set; }
        public DbSet<ISO14067> ISO14067s { get; set; }
        public DbSet<ISO19880_1> ISO19880_1s { get; set; }
        public DbSet<ISOTR15916> ISOTR15916s { get; set; }
        public DbSet<ISO26142> ISO26142s { get; set; }
        public DbSet<ISOC23985> ISOC23985s { get; set; }
        public DbSet<ISO14040_14044> ISO14040_14044s { get; set; }
        public DbSet<ISO23306> ISO23306s { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ISO21087>().ToTable("ISO21087");
            modelBuilder.Entity<ISO14067>().ToTable("ISO14067");
            modelBuilder.Entity<ISO19880_1>().ToTable("ISO19880_1");
            modelBuilder.Entity<ISOTR15916>().ToTable("ISOTR15916");
            modelBuilder.Entity<ISO26142>().ToTable("ISO26142");
            modelBuilder.Entity<ISOC23985>().ToTable("ISOC23985");
            modelBuilder.Entity<ISO14040_14044>().ToTable("ISO14040_14044");
            modelBuilder.Entity<ISO23306>().ToTable("ISO23306");

            base.OnModelCreating(modelBuilder);
        }
    }
}
