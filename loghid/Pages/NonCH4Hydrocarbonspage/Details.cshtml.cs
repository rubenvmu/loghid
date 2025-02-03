using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.NonCH4Hydrocarbonspage
{
    public class DetailsModel : PageModel
    {
        private readonly Loghid.Data.LoghidDbContext _context;

        public DetailsModel(Loghid.Data.LoghidDbContext context)
        {
            _context = context;
        }

        public NonCH4Hydrocarbons NonCH4Hydrocarbons { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nonch4hydrocarbons = await _context.NonCH4Hydrocarbons.FirstOrDefaultAsync(m => m.Id == id);

            if (nonch4hydrocarbons is not null)
            {
                NonCH4Hydrocarbons = nonch4hydrocarbons;

                return Page();
            }

            return NotFound();
        }
    }
}
