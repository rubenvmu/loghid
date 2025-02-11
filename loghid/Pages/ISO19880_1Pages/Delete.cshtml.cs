using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Models;
using Loghid.data;

namespace loghid.Pages.ISO19880_1Pages
{
    public class DeleteModel : PageModel
    {
        private readonly Loghid.data.OtherISOsDbContext _context;

        public DeleteModel(Loghid.data.OtherISOsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ISO19880_1 ISO19880_1 { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iso19880_1 = await _context.ISO19880_1s.FirstOrDefaultAsync(m => m.Id == id);

            if (iso19880_1 is not null)
            {
                ISO19880_1 = iso19880_1;

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

            var iso19880_1 = await _context.ISO19880_1s.FindAsync(id);
            if (iso19880_1 != null)
            {
                ISO19880_1 = iso19880_1;
                _context.ISO19880_1s.Remove(ISO19880_1);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
