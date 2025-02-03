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

namespace loghid.Pages.Ammoniapage
{
    public class EditModel : PageModel
    {
        private readonly Loghid.Data.LoghidDbContext _context;

        public EditModel(Loghid.Data.LoghidDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Ammonia Ammonia { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ammonia =  await _context.Ammonia.FirstOrDefaultAsync(m => m.Id == id);
            if (ammonia == null)
            {
                return NotFound();
            }
            Ammonia = ammonia;
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

            _context.Attach(Ammonia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmmoniaExists(Ammonia.Id))
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

        private bool AmmoniaExists(int id)
        {
            return _context.Ammonia.Any(e => e.Id == id);
        }
    }
}
