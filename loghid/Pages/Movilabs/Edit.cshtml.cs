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
        private readonly Loghid.Data.SprinterLabShimadzuDbContext _context;

        public EditModel(Loghid.Data.SprinterLabShimadzuDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SprinterLab SprinterLab { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sprinterlab =  await _context.SprinterLab.FirstOrDefaultAsync(m => m.Id == id);
            if (sprinterlab == null)
            {
                return NotFound();
            }
            SprinterLab = sprinterlab;
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

            _context.Attach(SprinterLab).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SprinterLabExists(SprinterLab.Id))
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

        private bool SprinterLabExists(int id)
        {
            return _context.SprinterLab.Any(e => e.Id == id);
        }
    }
}
