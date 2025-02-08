using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Loghid.Data;
using Loghid.Models;

namespace Loghid.Data
{
    public class SprinterLabShimadzuGC2030DbContext : DbContext
    {
        public SprinterLabShimadzuGC2030DbContext(DbContextOptions<SprinterLabShimadzuGC2030DbContext> options)
            : base(options) { }

        public DbSet<SprinterLabShimadzuGC2030> SprinterLabs { get; set; }
        public DbSet<Precio> Precios { get; set; }
        public DbSet<SprinterLabShimadzuGC2030Entity> SprinterLabShimadzuGC2030Entities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SprinterLabShimadzuGC2030>(entity =>
            {
                entity.HasKey(e => e.Id);

                // Configuración de relaciones uno-a-uno con Precio
                entity.OwnsOne(e => e.PrecioVehiculo, precio =>
                {
                    precio.Property(p => p.Sistema).HasColumnName("PrecioVehiculo_Sistema");
                    precio.Property(p => p.RangoPrecio).HasColumnName("PrecioVehiculo_Rango");
                    precio.Property(p => p.PrecioBase).HasColumnName("PrecioVehiculo_Base");
                });

                entity.OwnsOne(e => e.PrecioTipoConversion, precio =>
                {
                    precio.Property(p => p.Sistema).HasColumnName("PrecioConversion_Sistema");
                    precio.Property(p => p.RangoPrecio).HasColumnName("PrecioConversion_Rango");
                    precio.Property(p => p.PrecioBase).HasColumnName("PrecioConversion_Base");
                });

                // Repetir patrón para todas las propiedades Precio...
                entity.OwnsOne(e => e.PrecioModeloEquipo, precio =>
                {
                    precio.Property(p => p.Sistema).HasColumnName("PrecioModeloEquipo_Sistema");
                    precio.Property(p => p.RangoPrecio).HasColumnName("PrecioModeloEquipo_Rango");
                    precio.Property(p => p.PrecioBase).HasColumnName("PrecioModeloEquipo_Base");
                });

                entity.OwnsOne(e => e.PrecioNormaHidrogeno, precio =>
                {
                    precio.Property(p => p.Sistema).HasColumnName("PrecioNormaHidrogeno_Sistema");
                    precio.Property(p => p.RangoPrecio).HasColumnName("PrecioNormaHidrogeno_Rango");
                    precio.Property(p => p.PrecioBase).HasColumnName("PrecioNormaHidrogeno_Base");
                });

                // Configurar índices para búsquedas frecuentes
                entity.HasIndex(e => e.ModeloEquipo).IsUnique();
                entity.HasIndex(e => e.NormaHidrogeno);
                entity.HasIndex(e => e.PurezaOptima);

                // Configurar valores por defecto
                entity.Property(e => e.Vehiculo).HasDefaultValue("Mercedes-Benz Sprinter");
                entity.Property(e => e.EnsayoPresion).HasDefaultValue(true);
                entity.Property(e => e.SensibilidadMinima).HasDefaultValue(0.1);
            });

            // Ensure Precio is not configured as a shared type
            modelBuilder.Entity<Precio>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(p => p.PrecioBase).HasColumnType("decimal(18,2)");
            });

            // Remove SQL Server-specific configurations
            // modelBuilder.UseCollation("Latin1_General_CI_AI");
            // modelBuilder.HasPerformanceLevelSql("S0");
            // modelBuilder.HasDatabaseMaxSize("250 GB");
        }
    }
}

// Agregar estas interfaces si son necesarias
public interface ISprinterLabShimadzuGC2030 { }
