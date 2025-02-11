using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Models;
using Loghid.data;

namespace loghid.Pages.ISO23306Pages
{
    public class DeleteModel : PageModel
    {
        private readonly Loghid.data.OtherISOsDbContext _context;

        public DeleteModel(Loghid.data.OtherISOsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ISO23306 ISO23306 { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iso23306 = await _context.ISO23306s.FirstOrDefaultAsync(m => m.Id == id);

            if (iso23306 is not null)
            {
                ISO23306 = iso23306;

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

            var iso23306 = await _context.ISO23306s.FindAsync(id);
            if (iso23306 != null)
            {
                ISO23306 = iso23306;
                _context.ISO23306s.Remove(ISO23306);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
