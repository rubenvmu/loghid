using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Models;
using Loghid.data;

namespace loghid.Pages.ISO21087Pages
{
    public class DeleteModel : PageModel
    {
        private readonly Loghid.data.OtherISOsDbContext _context;

        public DeleteModel(Loghid.data.OtherISOsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ISO21087 ISO21087 { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iso21087 = await _context.ISO21087s.FirstOrDefaultAsync(m => m.Id == id);

            if (iso21087 is not null)
            {
                ISO21087 = iso21087;

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

            var iso21087 = await _context.ISO21087s.FindAsync(id);
            if (iso21087 != null)
            {
                ISO21087 = iso21087;
                _context.ISO21087s.Remove(ISO21087);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
