using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Models;
using Loghid.data;

namespace loghid.Pages.ISO14067Pages
{
    public class IndexModel : PageModel
    {
        private readonly Loghid.data.OtherISOsDbContext _context;

        public IndexModel(Loghid.data.OtherISOsDbContext context)
        {
            _context = context;
        }

        public IList<ISO14067> ISO14067 { get;set; } = default!;

        public async Task OnGetAsync()
        {
            ISO14067 = await _context.ISO14067s.ToListAsync();
        }
    }
}
