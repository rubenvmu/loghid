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
    public class IndexModel : PageModel
    {
        private readonly Loghid.Data.LoghidDbContext _context;

        public IndexModel(Loghid.Data.LoghidDbContext context)
        {
            _context = context;
        }

        public IList<CarbonDioxide> CarbonDioxide { get;set; } = default!;

        public async Task OnGetAsync()
        {
            CarbonDioxide = await _context.CarbonDioxide.ToListAsync();
        }
    }
}
