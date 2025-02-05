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
    public class IndexModel : PageModel
    {
        private readonly Loghid.Data.LoghidClientMeasurementDbContext _context;

        public IndexModel(Loghid.Data.LoghidClientMeasurementDbContext context)
        {
            _context = context;
        }

        public IList<Substance> Substance { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Substance = await _context.Substances.ToListAsync();
        }
    }
}
