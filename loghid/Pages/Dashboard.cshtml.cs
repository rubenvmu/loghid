
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Loghid.Pages
{
    public class DashboardModel : PageModel
    {
        private readonly LoghidDbContext _context;

        public DashboardModel(LoghidDbContext context)
        {
            _context = context;
        }
        public List<Substance> CombinedSubstances { get; set; } = new List<Substance>();

        public async Task OnGetAsync()
        {
            var substancesTasks = new List<Task<List<Substance>>>
            {
                _context.Water.Select(w => new Substance { Id = w.Id, SubstanceName = "Water", IsoThreshold = w.IsoThreshold, MeasurementMethod = w.MeasurementMethod, MeasuredRange = w.MeasuredRange, Probability = w.Probability }).ToListAsync(),
                _context.Methane.Select(m => new Substance { Id = m.Id, SubstanceName = "Methane", IsoThreshold = m.IsoThreshold, MeasurementMethod = m.MeasurementMethod, MeasuredRange = m.MeasuredRange, Probability = m.Probability }).ToListAsync(),
                _context.NonCH4Hydrocarbons.Select(n => new Substance { Id = n.Id, SubstanceName = "NonCH4Hydrocarbons", IsoThreshold = n.IsoThreshold, MeasurementMethod = n.MeasurementMethod, MeasuredRange = n.MeasuredRange, Probability = n.Probability }).ToListAsync(),
                _context.Oxygen.Select(o => new Substance { Id = o.Id, SubstanceName = "Oxygen", IsoThreshold = o.IsoThreshold, MeasurementMethod = o.MeasurementMethod, MeasuredRange = o.MeasuredRange, Probability = o.Probability }).ToListAsync(),
                _context.Helium.Select(h => new Substance { Id = h.Id, SubstanceName = "Helium", IsoThreshold = h.IsoThreshold, MeasurementMethod = h.MeasurementMethod, MeasuredRange = h.MeasuredRange, Probability = h.Probability }).ToListAsync(),
                _context.Nitrogen.Select(n => new Substance { Id = n.Id, SubstanceName = "Nitrogen", IsoThreshold = n.IsoThreshold, MeasurementMethod = n.MeasurementMethod, MeasuredRange = n.MeasuredRange, Probability = n.Probability }).ToListAsync(),
                _context.Argon.Select(a => new Substance { Id = a.Id, SubstanceName = "Argon", IsoThreshold = a.IsoThreshold, MeasurementMethod = a.MeasurementMethod, MeasuredRange = a.MeasuredRange, Probability = a.Probability }).ToListAsync(),
                _context.CarbonDioxide.Select(c => new Substance { Id = c.Id, SubstanceName = "CarbonDioxide", IsoThreshold = c.IsoThreshold, MeasurementMethod = c.MeasurementMethod, MeasuredRange = c.MeasuredRange, Probability = c.Probability }).ToListAsync(),
                _context.CarbonMonoxide.Select(c => new Substance { Id = c.Id, SubstanceName = "CarbonMonoxide", IsoThreshold = c.IsoThreshold, MeasurementMethod = c.MeasurementMethod, MeasuredRange = c.MeasuredRange, Probability = c.Probability }).ToListAsync(),
                _context.SulphurCompounds.Select(s => new Substance { Id = s.Id, SubstanceName = "SulphurCompounds", IsoThreshold = s.IsoThreshold, MeasurementMethod = s.MeasurementMethod, MeasuredRange = s.MeasuredRange, Probability = s.Probability }).ToListAsync(),
                _context.Formaldehyde.Select(f => new Substance { Id = f.Id, SubstanceName = "Formaldehyde", IsoThreshold = f.IsoThreshold, MeasurementMethod = f.MeasurementMethod, MeasuredRange = f.MeasuredRange, Probability = f.Probability }).ToListAsync(),
                _context.FormicAcid.Select(f => new Substance { Id = f.Id, SubstanceName = "FormicAcid", IsoThreshold = f.IsoThreshold, MeasurementMethod = f.MeasurementMethod, MeasuredRange = f.MeasuredRange, Probability = f.Probability }).ToListAsync(),
                _context.Ammonia.Select(a => new Substance { Id = a.Id, SubstanceName = "Ammonia", IsoThreshold = a.IsoThreshold, MeasurementMethod = a.MeasurementMethod, MeasuredRange = a.MeasuredRange, Probability = a.Probability }).ToListAsync(),
                _context.HalogenatedCompounds.Select(h => new Substance { Id = h.Id, SubstanceName = "HalogenatedCompounds", IsoThreshold = h.IsoThreshold, MeasurementMethod = h.MeasurementMethod, MeasuredRange = h.MeasuredRange, Probability = h.Probability }).ToListAsync(),
                _context.Hydrocarbons.Select(h => new Substance { Id = h.Id, SubstanceName = "Hydrocarbons", IsoThreshold = h.IsoThreshold, MeasurementMethod = h.MeasurementMethod, MeasuredRange = h.MeasuredRange, Probability = h.Probability }).ToListAsync()
            };

            var substancesResults = await Task.WhenAll(substancesTasks);
            CombinedSubstances = substancesResults.SelectMany(s => s).OrderBy(s => s.SubstanceName).ToList();
        }
    }
}