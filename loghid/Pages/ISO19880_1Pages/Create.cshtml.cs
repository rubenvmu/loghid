using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Loghid.Models;
using Loghid.data;

namespace loghid.Pages.ISO19880_1Pages
{
    public class CreateModel : PageModel
    {
        private readonly Loghid.data.OtherISOsDbContext _context;

        public CreateModel(Loghid.data.OtherISOsDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ISO19880_1 ISO19880_1 { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ISO19880_1s.Add(ISO19880_1);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
