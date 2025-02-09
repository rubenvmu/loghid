using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.Movilabs
{
    public class DetailsModel : PageModel
    {
        private readonly Loghid.Data.SprinterLabShimadzuDbContext _context;

        public DetailsModel(Loghid.Data.SprinterLabShimadzuDbContext context)
        {
            _context = context;
        }

        public SprinterLab SprinterLab { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sprinterlab = await _context.SprinterLab.FirstOrDefaultAsync(m => m.Id == id);

            if (sprinterlab is not null)
            {
                SprinterLab = sprinterlab;

                return Page();
            }

            return NotFound();
        }
    }
}
