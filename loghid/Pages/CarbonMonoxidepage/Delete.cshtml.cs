using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.CarbonMonoxidepage
{
    public class DeleteModel : PageModel
    {
        private readonly Loghid.Data.LoghidDbContext _context;

        public DeleteModel(Loghid.Data.LoghidDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CarbonMonoxide CarbonMonoxide { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carbonmonoxide = await _context.CarbonMonoxide.FirstOrDefaultAsync(m => m.Id == id);

            if (carbonmonoxide is not null)
            {
                CarbonMonoxide = carbonmonoxide;

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

            var carbonmonoxide = await _context.CarbonMonoxide.FindAsync(id);
            if (carbonmonoxide != null)
            {
                CarbonMonoxide = carbonmonoxide;
                _context.CarbonMonoxide.Remove(CarbonMonoxide);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
