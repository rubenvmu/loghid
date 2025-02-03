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

namespace loghid.Pages.CarbonDioxidepage
{
    public class EditModel : PageModel
    {
        private readonly Loghid.Data.LoghidDbContext _context;

        public EditModel(Loghid.Data.LoghidDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CarbonDioxide CarbonDioxide { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carbondioxide =  await _context.CarbonDioxide.FirstOrDefaultAsync(m => m.Id == id);
            if (carbondioxide == null)
            {
                return NotFound();
            }
            CarbonDioxide = carbondioxide;
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

            _context.Attach(CarbonDioxide).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarbonDioxideExists(CarbonDioxide.Id))
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

        private bool CarbonDioxideExists(int id)
        {
            return _context.CarbonDioxide.Any(e => e.Id == id);
        }
    }
}
