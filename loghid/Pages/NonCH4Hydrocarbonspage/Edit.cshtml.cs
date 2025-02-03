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

namespace loghid.Pages.NonCH4Hydrocarbonspage
{
    public class EditModel : PageModel
    {
        private readonly Loghid.Data.LoghidDbContext _context;

        public EditModel(Loghid.Data.LoghidDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public NonCH4Hydrocarbons NonCH4Hydrocarbons { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nonch4hydrocarbons =  await _context.NonCH4Hydrocarbons.FirstOrDefaultAsync(m => m.Id == id);
            if (nonch4hydrocarbons == null)
            {
                return NotFound();
            }
            NonCH4Hydrocarbons = nonch4hydrocarbons;
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

            _context.Attach(NonCH4Hydrocarbons).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NonCH4HydrocarbonsExists(NonCH4Hydrocarbons.Id))
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

        private bool NonCH4HydrocarbonsExists(int id)
        {
            return _context.NonCH4Hydrocarbons.Any(e => e.Id == id);
        }
    }
}
