using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loghid.Pages
{
    public class IndexModel(LoghidDbContext context) : PageModel
    {
        private readonly LoghidDbContext _context = context;

        // Propiedad que contiene las sustancias cargadas desde la base de datos
        public required IEnumerable<SubstanceDisplayModel> Substances { get; set; }

        // Método OnGet para cargar datos de la base de datos
        public async Task OnGetAsync()
        {
            // Obtener las sustancias con sus datos asociados desde la base de datos
            Substances = await _context.Substances
                .Include(s => s.Data) // Asegúrate de incluir los datos relacionados
                .Select(s => new SubstanceDisplayModel(
                    s.Name, 
                    s.Data.Select(d => new SubstanceDataModel 
                    { 
                        Id = d.Id, 
                        IsoThreshold = d.IsoThreshold, 
                        Probability = d.Probability 
                    })
                ))
                .ToListAsync();
        }
    }

    // Modelo para representar las sustancias con sus datos
    public class SubstanceDisplayModel(string name, IEnumerable<ISubstanceData> data)
    {
        public string Name { get; set; } = name;
        public IEnumerable<ISubstanceData> Data { get; set; } = data;
    }

    // Modelo para los datos de las sustancias
    public class SubstanceDataModel : ISubstanceData
    {
        public int Id { get; set; }
        public double IsoThreshold { get; set; }
        public required string Probability { get; set; }
    }

    // Interfaz que define las propiedades comunes para los datos de sustancias
    public interface ISubstanceData
    {
        int Id { get; set; }
        double IsoThreshold { get; set; }
        string Probability { get; set; }
    }

    // DbContext para la base de datos
    public class LoghidDbContext : DbContext
    {
        public LoghidDbContext(DbContextOptions<LoghidDbContext> options) : base(options)
        { }

        public DbSet<Substance> Substances { get; set; }
    }

    // Clase que representa una sustancia en la base de datos
    public class Substance
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required ICollection<SubstanceData> Data { get; set; }
    }

    // Clase que representa los datos de una sustancia específica en la base de datos
    public class SubstanceData : ISubstanceData
    {
        public int Id { get; set; }
        public double IsoThreshold { get; set; }
        public required string Probability { get; set; }
        public int SubstanceId { get; set; }
        public required Substance Substance { get; set; }
    }
}