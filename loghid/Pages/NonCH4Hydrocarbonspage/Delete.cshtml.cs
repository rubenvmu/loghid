using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.NonCH4Hydrocarbonspage
{
    public class DeleteModel : PageModel
    {
        private readonly Loghid.Data.LoghidDbContext _context;

        public DeleteModel(Loghid.Data.LoghidDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public NonCH4Hydrocarbons NonCH4Hydrocarbons { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nonch4hydrocarbons = await _context.NonCH4Hydrocarbons.FirstOrDefaultAsync(m => m.Id == id);

            if (nonch4hydrocarbons is not null)
            {
                NonCH4Hydrocarbons = nonch4hydrocarbons;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nonch4hydrocarbons = await _context.NonCH4Hydrocarbons.FindAsync(id);
            if (nonch4hydrocarbons != null)
            {
                NonCH4Hydrocarbons = nonch4hydrocarbons;
                _context.NonCH4Hydrocarbons.Remove(NonCH4Hydrocarbons);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
