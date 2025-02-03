using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.FormicAcidpage
{
    public class DeleteModel : PageModel
    {
        private readonly Loghid.Data.LoghidDbContext _context;

        public DeleteModel(Loghid.Data.LoghidDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FormicAcid FormicAcid { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formicacid = await _context.FormicAcid.FirstOrDefaultAsync(m => m.Id == id);

            if (formicacid is not null)
            {
                FormicAcid = formicacid;

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

            var formicacid = await _context.FormicAcid.FindAsync(id);
            if (formicacid != null)
            {
                FormicAcid = formicacid;
                _context.FormicAcid.Remove(FormicAcid);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
