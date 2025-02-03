using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.SulphurCompoundspage
{
    public class DeleteModel : PageModel
    {
        private readonly Loghid.Data.LoghidDbContext _context;

        public DeleteModel(Loghid.Data.LoghidDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SulphurCompounds SulphurCompounds { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sulphurcompounds = await _context.SulphurCompounds.FirstOrDefaultAsync(m => m.Id == id);

            if (sulphurcompounds is not null)
            {
                SulphurCompounds = sulphurcompounds;

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

            var sulphurcompounds = await _context.SulphurCompounds.FindAsync(id);
            if (sulphurcompounds != null)
            {
                SulphurCompounds = sulphurcompounds;
                _context.SulphurCompounds.Remove(SulphurCompounds);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
