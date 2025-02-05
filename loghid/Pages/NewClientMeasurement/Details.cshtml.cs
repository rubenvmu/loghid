using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.NewClientMeasurement
{
    public class DetailsModel : PageModel
    {
        private readonly Loghid.Data.LoghidClientMeasurementDbContext _context;

        public DetailsModel(Loghid.Data.LoghidClientMeasurementDbContext context)
        {
            _context = context;
        }

        public Substance Substance { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var substance = await _context.Substances.FirstOrDefaultAsync(m => m.Id == id);

            if (substance is not null)
            {
                Substance = substance;

                return Page();
            }

            return NotFound();
        }
    }
}
