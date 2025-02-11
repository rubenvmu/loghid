using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Models;
using Loghid.data;

namespace loghid.Pages.ISO21087Pages
{
    public class DetailsModel : PageModel
    {
        private readonly Loghid.data.OtherISOsDbContext _context;

        public DetailsModel(Loghid.data.OtherISOsDbContext context)
        {
            _context = context;
        }

        public ISO21087 ISO21087 { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iso21087 = await _context.ISO21087s.FirstOrDefaultAsync(m => m.Id == id);

            if (iso21087 is not null)
            {
                ISO21087 = iso21087;

                return Page();
            }

            return NotFound();
        }
    }
}
