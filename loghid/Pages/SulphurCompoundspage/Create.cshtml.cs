using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.SulphurCompoundspage
{
    public class CreateModel : PageModel
    {
        private readonly Loghid.Data.LoghidDbContext _context;

        public CreateModel(Loghid.Data.LoghidDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SulphurCompounds SulphurCompounds { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.SulphurCompounds.Add(SulphurCompounds);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
