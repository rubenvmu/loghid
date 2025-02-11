using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Models;
using Loghid.data;

namespace loghid.Pages.ISOTR15916Pages
{
    public class DeleteModel : PageModel
    {
        private readonly Loghid.data.OtherISOsDbContext _context;

        public DeleteModel(Loghid.data.OtherISOsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ISOTR15916 ISOTR15916 { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var isotr15916 = await _context.ISOTR15916s.FirstOrDefaultAsync(m => m.Id == id);

            if (isotr15916 is not null)
            {
                ISOTR15916 = isotr15916;

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

            var isotr15916 = await _context.ISOTR15916s.FindAsync(id);
            if (isotr15916 != null)
            {
                ISOTR15916 = isotr15916;
                _context.ISOTR15916s.Remove(ISOTR15916);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
