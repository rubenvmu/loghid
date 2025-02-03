using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.HydrocarbonsPage
{
    public class DeleteModel : PageModel
    {
        private readonly Loghid.Data.LoghidDbContext _context;

        public DeleteModel(Loghid.Data.LoghidDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Hydrocarbons Hydrocarbons { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hydrocarbons = await _context.Hydrocarbons.FirstOrDefaultAsync(m => m.Id == id);

            if (hydrocarbons is not null)
            {
                Hydrocarbons = hydrocarbons;

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

            var hydrocarbons = await _context.Hydrocarbons.FindAsync(id);
            if (hydrocarbons != null)
            {
                Hydrocarbons = hydrocarbons;
                _context.Hydrocarbons.Remove(Hydrocarbons);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
