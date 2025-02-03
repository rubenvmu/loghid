using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.Methanepage
{
    public class DeleteModel : PageModel
    {
        private readonly Loghid.Data.LoghidDbContext _context;

        public DeleteModel(Loghid.Data.LoghidDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Methane Methane { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var methane = await _context.Methane.FirstOrDefaultAsync(m => m.Id == id);

            if (methane is not null)
            {
                Methane = methane;

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

            var methane = await _context.Methane.FindAsync(id);
            if (methane != null)
            {
                Methane = methane;
                _context.Methane.Remove(Methane);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
