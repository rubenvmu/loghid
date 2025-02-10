using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.Movilabs
{
    public class CreateModel : PageModel
    {
        private readonly Loghid.Data.eSprinterLabShimadzuDbContext _context;

        public CreateModel(Loghid.Data.eSprinterLabShimadzuDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public eSprinterLab eSprinterLab { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.eSprinterLab.Add(eSprinterLab);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
