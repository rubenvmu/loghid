using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.HalogenatedCompundspage
{
    public class DeleteModel : PageModel
    {
        private readonly Loghid.Data.LoghidDbContext _context;

        public DeleteModel(Loghid.Data.LoghidDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public HalogenatedCompounds HalogenatedCompounds { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var halogenatedcompounds = await _context.HalogenatedCompounds.FirstOrDefaultAsync(m => m.Id == id);

            if (halogenatedcompounds is not null)
            {
                HalogenatedCompounds = halogenatedcompounds;

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

            var halogenatedcompounds = await _context.HalogenatedCompounds.FindAsync(id);
            if (halogenatedcompounds != null)
            {
                HalogenatedCompounds = halogenatedcompounds;
                _context.HalogenatedCompounds.Remove(HalogenatedCompounds);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
