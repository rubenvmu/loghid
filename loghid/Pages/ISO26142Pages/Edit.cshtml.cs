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

namespace loghid.Pages.ISO26142Pages
{
    public class EditModel : PageModel
    {
        private readonly Loghid.data.OtherISOsDbContext _context;

        public EditModel(Loghid.data.OtherISOsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ISO26142 ISO26142 { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iso26142 =  await _context.ISO26142s.FirstOrDefaultAsync(m => m.Id == id);
            if (iso26142 == null)
            {
                return NotFound();
            }
            ISO26142 = iso26142;
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

            _context.Attach(ISO26142).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ISO26142Exists(ISO26142.Id))
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

        private bool ISO26142Exists(int id)
        {
            return _context.ISO26142s.Any(e => e.Id == id);
        }
    }
}
