using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Models;
using Loghid.data;

namespace loghid.Pages.ISO26142Pages
{
    public class DeleteModel : PageModel
    {
        private readonly Loghid.data.OtherISOsDbContext _context;

        public DeleteModel(Loghid.data.OtherISOsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ISO26142 ISO26142 { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iso26142 = await _context.ISO26142s.FirstOrDefaultAsync(m => m.Id == id);

            if (iso26142 is not null)
            {
                ISO26142 = iso26142;

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

            var iso26142 = await _context.ISO26142s.FindAsync(id);
            if (iso26142 != null)
            {
                ISO26142 = iso26142;
                _context.ISO26142s.Remove(ISO26142);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
