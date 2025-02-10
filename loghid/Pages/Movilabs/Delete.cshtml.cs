using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.Movilabs
{
    public class DeleteModel : PageModel
    {
        private readonly Loghid.Data.eSprinterLabShimadzuDbContext _context;

        public DeleteModel(Loghid.Data.eSprinterLabShimadzuDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public eSprinterLab eSprinterLab { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var esprinterlab = await _context.eSprinterLab.FirstOrDefaultAsync(m => m.Id == id);

            if (esprinterlab is not null)
            {
                eSprinterLab = esprinterlab;

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

            var esprinterlab = await _context.eSprinterLab.FindAsync(id);
            if (esprinterlab != null)
            {
                eSprinterLab = esprinterlab;
                _context.eSprinterLab.Remove(eSprinterLab);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
