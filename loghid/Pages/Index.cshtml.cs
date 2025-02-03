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
    public class IndexModel : PageModel
    {
        private readonly LoghidDbContext _context;

        public IndexModel(LoghidDbContext context)
        {
            _context = context;
        }

        public IList<Substance> Substances { get; set; } = new List<Substance>();

        public async Task OnGetAsync()
        {
            Substances = await _context.Substances.ToListAsync();
        }
    }
}