using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace Loghid.Pages
{
    public class IndexModel : PageModel
    {
        private readonly LoghidDbContext _context;

        public IndexModel(LoghidDbContext context)
        {
            _context = context;
        }

        public IList<Substance> CombinedSubstances { get; set; } = new List<Substance>();

        public async Task OnGetAsync()
        {
            // Obtener todas las sustancias SIN el Include inválido
            CombinedSubstances = await _context.Substances
                .AsNoTracking() // Opcional para solo lectura
                .ToListAsync();
        }
    }
}