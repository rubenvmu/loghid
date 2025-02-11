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

namespace loghid.Pages.ISOTR15916Pages
{
    public class EditModel : PageModel
    {
        private readonly Loghid.data.OtherISOsDbContext _context;

        public EditModel(Loghid.data.OtherISOsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ISOTR15916 ISOTR15916 { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var isotr15916 =  await _context.ISOTR15916s.FirstOrDefaultAsync(m => m.Id == id);
            if (isotr15916 == null)
            {
                return NotFound();
            }
            ISOTR15916 = isotr15916;
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

            _context.Attach(ISOTR15916).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ISOTR15916Exists(ISOTR15916.Id))
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

        private bool ISOTR15916Exists(int id)
        {
            return _context.ISOTR15916s.Any(e => e.Id == id);
        }
    }
}
