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

        public ClientMeasurement ClientMeasurement { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientmeasurement = await _context.Measurements.FirstOrDefaultAsync(m => m.Id_Measurement == id);

            if (clientmeasurement is not null)
            {
                ClientMeasurement = clientmeasurement;

                return Page();
            }

            return NotFound();
        }
    }
}
