using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Loghid.Data;
using Loghid.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Loghid.Pages
{
    public class DashboardSearchModel : PageModel
    {
        private readonly LoghidDbContext _context;

        public DashboardSearchModel(LoghidDbContext context)
        {
            _context = context;
        }

        public List<Substance> Substances { get; set; } = new List<Substance>();

        [BindProperty(SupportsGet = true)]
        public string? SearchTerm { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            if (!string.IsNullOrEmpty(SearchTerm))
            {
                Substances = await _context.Substances
                    .Where(s => s.SubstanceName.Contains(SearchTerm))
                    .ToListAsync();
            }
            else
            {
                Substances = await _context.Substances.ToListAsync();
            }

            return Page();
        }
    }
}