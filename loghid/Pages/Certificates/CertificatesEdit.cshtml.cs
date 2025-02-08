using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.Certificates
{
    public class CertificatesEditModel : PageModel
    {
        private readonly Loghid.Data.LoghidClientMeasurementDbContext _context;

        public CertificatesEditModel(Loghid.Data.LoghidClientMeasurementDbContext context)
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

            var clientmeasurement =  await _context.Measurements.FirstOrDefaultAsync(m => m.Id_Measurement == id);
            if (clientmeasurement == null)
            {
                return NotFound();
            }
            ClientMeasurement = clientmeasurement;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ClientMeasurement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientMeasurementExists(ClientMeasurement.Id_Measurement))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ClientMeasurementExists(int id)
        {
            return _context.Measurements.Any(e => e.Id_Measurement == id);
        }
    }
}
