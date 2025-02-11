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

namespace loghid.Pages.ISO19880_1Pages
{
    public class EditModel : PageModel
    {
        private readonly Loghid.data.OtherISOsDbContext _context;

        public EditModel(Loghid.data.OtherISOsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ISO19880_1 ISO19880_1 { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iso19880_1 =  await _context.ISO19880_1s.FirstOrDefaultAsync(m => m.Id == id);
            if (iso19880_1 == null)
            {
                return NotFound();
            }
            ISO19880_1 = iso19880_1;
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

            _context.Attach(ISO19880_1).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ISO19880_1Exists(ISO19880_1.Id))
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

        private bool ISO19880_1Exists(int id)
        {
            return _context.ISO19880_1s.Any(e => e.Id == id);
        }
    }
}
