using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Models;
using Loghid.data;

namespace loghid.Pages.ISOTR15916Pages
{
    public class IndexModel : PageModel
    {
        private readonly Loghid.data.OtherISOsDbContext _context;

        public IndexModel(Loghid.data.OtherISOsDbContext context)
        {
            _context = context;
        }

        public IList<ISOTR15916> ISOTR15916 { get;set; } = default!;

        public async Task OnGetAsync()
        {
            ISOTR15916 = await _context.ISOTR15916s.ToListAsync();
        }
    }
}
