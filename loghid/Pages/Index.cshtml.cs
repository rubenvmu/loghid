using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Models;
using Loghid.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Loghid.Pages
{
    public class IndexModel : PageModel
    {
        private readonly LoghidDbContext _context;

        // Inicializa la lista para evitar problemas de nullabilidad
        public IList<Substance> Substances { get; set; } = new List<Substance>();

        // Constructor con inyección de dependencias
        public IndexModel(LoghidDbContext context)
        {
            _context = context;
        }

        // Método para manejar la solicitud GET de forma asincrónica
        public async Task OnGetAsync()
        {
            if (_context.Substances != null) // Verifica que la tabla exista
            {
                Substances = await _context.Substances.ToListAsync();
            }
        }
    }
}