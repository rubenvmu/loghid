using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Loghid.Models;
using Loghid.data;

namespace loghid.Pages.ISO14040_14044Pages
{
    public class EditModel : PageModel
    {
        private readonly Loghid.data.OtherISOsDbContext _context;

        public EditModel(Loghid.data.OtherISOsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ISO14040_14044 ISO14040_14044 { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iso14040_14044 =  await _context.ISO14040_14044s.FirstOrDefaultAsync(m => m.Id == id);
            if (iso14040_14044 == null)
            {
                return NotFound();
            }
            ISO14040_14044 = iso14040_14044;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ISO14040_14044).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ISO14040_14044Exists(ISO14040_14044.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ISO14040_14044Exists(int id)
        {
            return _context.ISO14040_14044s.Any(e => e.Id == id);
        }
    }
}
