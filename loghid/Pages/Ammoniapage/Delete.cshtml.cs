using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.Ammoniapage
{
    public class DeleteModel : PageModel
    {
        private readonly Loghid.Data.LoghidDbContext _context;

        public DeleteModel(Loghid.Data.LoghidDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Ammonia Ammonia { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ammonia = await _context.Ammonia.FirstOrDefaultAsync(m => m.Id == id);

            if (ammonia is not null)
            {
                Ammonia = ammonia;

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

            var ammonia = await _context.Ammonia.FindAsync(id);
            if (ammonia != null)
            {
                Ammonia = ammonia;
                _context.Ammonia.Remove(Ammonia);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
