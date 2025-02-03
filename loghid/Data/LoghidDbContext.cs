using Microsoft.EntityFrameworkCore;
using Loghid.Models;

namespace Loghid.Data
{
    public class LoghidDbContext : DbContext
    {
        public LoghidDbContext(DbContextOptions<LoghidDbContext> options)
            : base(options)
        {
        }

        public DbSet<Substance> Substances { get; set; } = default!;

        public DbSet<Water> Water { get; set; }
        public DbSet<Methane> Methane { get; set; }
        public DbSet<NonCH4Hydrocarbons> NonCH4Hydrocarbons { get; set; }
        public DbSet<Oxygen> Oxygen { get; set; }
        public DbSet<Helium> Helium { get; set; }
        public DbSet<Nitrogen> Nitrogen { get; set; }
        public DbSet<Argon> Argon { get; set; }
        public DbSet<CarbonDioxide> CarbonDioxide { get; set; }
        public DbSet<CarbonMonoxide> CarbonMonoxide { get; set; }
        public DbSet<SulphurCompounds> SulphurCompounds { get; set; }
        public DbSet<Formaldehyde> Formaldehyde { get; set; }
        public DbSet<FormicAcid> FormicAcid { get; set; }
        public DbSet<Ammonia> Ammonia { get; set; }
        public DbSet<HalogenatedCompounds> HalogenatedCompounds { get; set; }
        public DbSet<Hydrocarbons> Hydrocarbons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Water>().ToTable("Water");
            modelBuilder.Entity<Methane>().ToTable("Methane");
            modelBuilder.Entity<NonCH4Hydrocarbons>().ToTable("NonCH4Hydrocarbons");
            modelBuilder.Entity<Oxygen>().ToTable("Oxygen");
            modelBuilder.Entity<Helium>().ToTable("Helium");
            modelBuilder.Entity<Nitrogen>().ToTable("Nitrogen");
            modelBuilder.Entity<Argon>().ToTable("Argon");
            modelBuilder.Entity<CarbonDioxide>().ToTable("CarbonDioxide");
            modelBuilder.Entity<CarbonMonoxide>().ToTable("CarbonMonoxide");
            modelBuilder.Entity<SulphurCompounds>().ToTable("SulphurCompounds");
            modelBuilder.Entity<Formaldehyde>().ToTable("Formaldehyde");
            modelBuilder.Entity<FormicAcid>().ToTable("FormicAcid");
            modelBuilder.Entity<Ammonia>().ToTable("Ammonia");
            modelBuilder.Entity<HalogenatedCompounds>().ToTable("HalogenatedCompounds");
            modelBuilder.Entity<Hydrocarbons>().ToTable("Hydrocarbons");
        }


}

}