using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Controllers
{
    public class CarbonDioxideController : Controller
    {
        private readonly LoghidDbContext _context;

        public CarbonDioxideController(LoghidDbContext context)
        {
            _context = context;
        }

        // GET: CarbonDioxide
        public async Task<IActionResult> Index()
        {
            return View(await _context.CarbonDioxide.ToListAsync());
        }

        // GET: CarbonDioxide/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carbonDioxide = await _context.CarbonDioxide
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carbonDioxide == null)
            {
                return NotFound();
            }

            return View(carbonDioxide);
        }

        // GET: CarbonDioxide/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CarbonDioxide/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsoThreshold,PemResultMin,PemResultMax,Probability")] CarbonDioxide carbonDioxide)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carbonDioxide);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carbonDioxide);
        }

        // GET: CarbonDioxide/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carbonDioxide = await _context.CarbonDioxide.FindAsync(id);
            if (carbonDioxide == null)
            {
                return NotFound();
            }
            return View(carbonDioxide);
        }

        // POST: CarbonDioxide/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsoThreshold,PemResultMin,PemResultMax,Probability")] CarbonDioxide carbonDioxide)
        {
            if (id != carbonDioxide.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carbonDioxide);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarbonDioxideExists(carbonDioxide.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(carbonDioxide);
        }

        // GET: CarbonDioxide/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carbonDioxide = await _context.CarbonDioxide
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carbonDioxide == null)
            {
                return NotFound();
            }

            return View(carbonDioxide);
        }

        // POST: CarbonDioxide/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carbonDioxide = await _context.CarbonDioxide.FindAsync(id);
            if (carbonDioxide != null)
            {
                _context.CarbonDioxide.Remove(carbonDioxide);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarbonDioxideExists(int id)
        {
            return _context.CarbonDioxide.Any(e => e.Id == id);
        }
    }
}
