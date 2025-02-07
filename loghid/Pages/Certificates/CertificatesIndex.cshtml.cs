using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;


namespace Loghid.Pages
{
    public class CertificatesIndex : PageModel
    {
        private readonly Loghid.Data.LoghidClientMeasurementDbContext _context;


        public CertificatesIndex(Loghid.Data.LoghidClientMeasurementDbContext context)
        {
            _context = context;
        }

        public IList<ClientMeasurement> ClientMeasurement { get; set; } = new List<ClientMeasurement>();

        public async Task OnGetAsync()
        {
            ClientMeasurement = await _context.Measurements.ToListAsync();
        }
    }
}
