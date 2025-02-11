using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Models;
using Loghid.data;

namespace loghid.Pages.ISO19880_1Pages
{
    public class IndexModel : PageModel
    {
        private readonly Loghid.data.OtherISOsDbContext _context;

        public IndexModel(Loghid.data.OtherISOsDbContext context)
        {
            _context = context;
        }

        public IList<ISO19880_1> ISO19880_1 { get;set; } = default!;

        public async Task OnGetAsync()
        {
            ISO19880_1 = await _context.ISO19880_1s.ToListAsync();
        }
    }
}
