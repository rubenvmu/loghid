using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.CarbonDioxidepage
{
    public class DetailsModel : PageModel
    {
        private readonly Loghid.Data.LoghidDbContext _context;

        public DetailsModel(Loghid.Data.LoghidDbContext context)
        {
            _context = context;
        }

        public CarbonDioxide CarbonDioxide { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carbondioxide = await _context.CarbonDioxide.FirstOrDefaultAsync(m => m.Id == id);

            if (carbondioxide is not null)
            {
                CarbonDioxide = carbondioxide;

                return Page();
            }

            return NotFound();
        }
    }
}
