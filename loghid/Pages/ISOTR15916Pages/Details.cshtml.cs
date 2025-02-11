using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Models;
using Loghid.data;

namespace loghid.Pages.ISOTR15916Pages
{
    public class DetailsModel : PageModel
    {
        private readonly Loghid.data.OtherISOsDbContext _context;

        public DetailsModel(Loghid.data.OtherISOsDbContext context)
        {
            _context = context;
        }

        public ISOTR15916 ISOTR15916 { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var isotr15916 = await _context.ISOTR15916s.FirstOrDefaultAsync(m => m.Id == id);

            if (isotr15916 is not null)
            {
                ISOTR15916 = isotr15916;

                return Page();
            }

            return NotFound();
        }
    }
}
