using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.Heliumpage
{
    public class DeleteModel : PageModel
    {
        private readonly Loghid.Data.LoghidDbContext _context;

        public DeleteModel(Loghid.Data.LoghidDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Helium Helium { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var helium = await _context.Helium.FirstOrDefaultAsync(m => m.Id == id);

            if (helium is not null)
            {
                Helium = helium;

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

            var helium = await _context.Helium.FindAsync(id);
            if (helium != null)
            {
                Helium = helium;
                _context.Helium.Remove(Helium);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
