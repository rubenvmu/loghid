using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Models;
using Loghid.data;

namespace loghid.Pages.ISOC23985Pages
{
    public class IndexModel : PageModel
    {
        private readonly Loghid.data.OtherISOsDbContext _context;

        public IndexModel(Loghid.data.OtherISOsDbContext context)
        {
            _context = context;
        }

        public IList<ISOC23985> ISOC23985 { get;set; } = default!;

        public async Task OnGetAsync()
        {
            ISOC23985 = await _context.ISOC23985s.ToListAsync();
        }
    }
}
