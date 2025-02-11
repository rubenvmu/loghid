using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Models;
using Loghid.data;

namespace loghid.Pages.ISOC23985Pages
{
    public class DeleteModel : PageModel
    {
        private readonly Loghid.data.OtherISOsDbContext _context;

        public DeleteModel(Loghid.data.OtherISOsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ISOC23985 ISOC23985 { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var isoc23985 = await _context.ISOC23985s.FirstOrDefaultAsync(m => m.Id == id);

            if (isoc23985 is not null)
            {
                ISOC23985 = isoc23985;

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

            var isoc23985 = await _context.ISOC23985s.FindAsync(id);
            if (isoc23985 != null)
            {
                ISOC23985 = isoc23985;
                _context.ISOC23985s.Remove(ISOC23985);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
