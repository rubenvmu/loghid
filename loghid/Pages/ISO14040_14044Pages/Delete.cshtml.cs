using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Models;
using Loghid.data;

namespace loghid.Pages.ISO14040_14044Pages
{
    public class DeleteModel : PageModel
    {
        private readonly Loghid.data.OtherISOsDbContext _context;

        public DeleteModel(Loghid.data.OtherISOsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ISO14040_14044 ISO14040_14044 { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iso14040_14044 = await _context.ISO14040_14044s.FirstOrDefaultAsync(m => m.Id == id);

            if (iso14040_14044 is not null)
            {
                ISO14040_14044 = iso14040_14044;

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

            var iso14040_14044 = await _context.ISO14040_14044s.FindAsync(id);
            if (iso14040_14044 != null)
            {
                ISO14040_14044 = iso14040_14044;
                _context.ISO14040_14044s.Remove(ISO14040_14044);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
