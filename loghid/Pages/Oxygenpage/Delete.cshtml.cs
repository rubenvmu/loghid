using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.Oxygenpage
{
    public class DeleteModel : PageModel
    {
        private readonly Loghid.Data.LoghidDbContext _context;

        public DeleteModel(Loghid.Data.LoghidDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Oxygen Oxygen { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oxygen = await _context.Oxygen.FirstOrDefaultAsync(m => m.Id == id);

            if (oxygen is not null)
            {
                Oxygen = oxygen;

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

            var oxygen = await _context.Oxygen.FindAsync(id);
            if (oxygen != null)
            {
                Oxygen = oxygen;
                _context.Oxygen.Remove(Oxygen);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
