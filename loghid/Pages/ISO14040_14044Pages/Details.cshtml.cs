using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Models;
using Loghid.data;

namespace loghid.Pages.ISO14040_14044Pages
{
    public class DetailsModel : PageModel
    {
        private readonly Loghid.data.OtherISOsDbContext _context;

        public DetailsModel(Loghid.data.OtherISOsDbContext context)
        {
            _context = context;
        }

        public ISO14040_14044 ISO14040_14044 { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iso14040_14044 = await _context.ISO14040_14044s.FirstOrDefaultAsync(m => m.Id == id);

            if (iso14040_14044 is not null)
            {
                ISO14040_14044 = iso14040_14044;

                return Page();
            }

            return NotFound();
        }
    }
}
