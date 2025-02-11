using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Models;
using Loghid.data;

namespace loghid.Pages.ISO14040_14044Pages
{
    public class IndexModel : PageModel
    {
        private readonly Loghid.data.OtherISOsDbContext _context;

        public IndexModel(Loghid.data.OtherISOsDbContext context)
        {
            _context = context;
        }

        public IList<ISO14040_14044> ISO14040_14044 { get;set; } = default!;

        public async Task OnGetAsync()
        {
            ISO14040_14044 = await _context.ISO14040_14044s.ToListAsync();
        }
    }
}
