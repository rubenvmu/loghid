using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.Movilabs
{
    public class EditModel : PageModel
    {
        private readonly Loghid.Data.eSprinterLabShimadzuDbContext _context;

        public EditModel(Loghid.Data.eSprinterLabShimadzuDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public eSprinterLab eSprinterLab { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var esprinterlab =  await _context.eSprinterLab.FirstOrDefaultAsync(m => m.Id == id);
            if (esprinterlab == null)
            {
                return NotFound();
            }
            eSprinterLab = esprinterlab;
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

            _context.Attach(eSprinterLab).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!eSprinterLabExists(eSprinterLab.Id))
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

        private bool eSprinterLabExists(int id)
        {
            return _context.eSprinterLab.Any(e => e.Id == id);
        }
    }
}
