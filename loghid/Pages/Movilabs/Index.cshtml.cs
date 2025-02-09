using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.Movilabs
{
    public class IndexModel : PageModel
    {
        private readonly Loghid.Data.SprinterLabShimadzuDbContext _context;

        public IndexModel(Loghid.Data.SprinterLabShimadzuDbContext context)
        {
            _context = context;
        }

        public IList<SprinterLab> SprinterLab { get;set; } = default!;

        public async Task OnGetAsync()
        {
            SprinterLab = await _context.SprinterLab.ToListAsync();
        }
    }
}
