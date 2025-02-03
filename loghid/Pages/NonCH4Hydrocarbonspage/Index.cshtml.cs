using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.NonCH4Hydrocarbonspage
{
    public class IndexModel : PageModel
    {
        private readonly Loghid.Data.LoghidDbContext _context;

        public IndexModel(Loghid.Data.LoghidDbContext context)
        {
            _context = context;
        }

        public IList<NonCH4Hydrocarbons> NonCH4Hydrocarbons { get;set; } = default!;

        public async Task OnGetAsync()
        {
            NonCH4Hydrocarbons = await _context.NonCH4Hydrocarbons.ToListAsync();
        }
    }
}
