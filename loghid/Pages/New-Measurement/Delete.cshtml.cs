using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.New_Measurement
{
    public class DeleteModel : PageModel
    {
        private readonly Loghid.Data.LoghidClientMeasurementDbContext _context;

        public DeleteModel(Loghid.Data.LoghidClientMeasurementDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientmeasurement = await _context.Measurements.FindAsync(id);
            if (clientmeasurement != null)
            {
                ClientMeasurement = clientmeasurement;
                _context.Measurements.Remove(ClientMeasurement);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
