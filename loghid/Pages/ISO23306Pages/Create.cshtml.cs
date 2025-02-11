using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Loghid.Models;
using Loghid.data;

namespace loghid.Pages.ISO23306Pages
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
        public ISO23306 ISO23306 { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ISO23306s.Add(ISO23306);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
