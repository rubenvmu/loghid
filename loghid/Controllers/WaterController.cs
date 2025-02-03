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
    public class WaterController : Controller
    {
        private readonly LoghidDbContext _context;

        public WaterController(LoghidDbContext context)
        {
            _context = context;
        }

        // GET: Water
        public async Task<IActionResult> Index()
        {
            return View(await _context.Water.ToListAsync());
        }

        // GET: Water/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var water = await _context.Water
                .FirstOrDefaultAsync(m => m.Id == id);
            if (water == null)
            {
                return NotFound();
            }

            return View(water);
        }

        // GET: Water/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Water/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsoThreshold,PemResult,Probability")] Water water)
        {
            if (ModelState.IsValid)
            {
                _context.Add(water);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(water);
        }

        // GET: Water/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var water = await _context.Water.FindAsync(id);
            if (water == null)
            {
                return NotFound();
            }
            return View(water);
        }

        // POST: Water/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsoThreshold,PemResult,Probability")] Water water)
        {
            if (id != water.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(water);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WaterExists(water.Id))
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
            return View(water);
        }

        // GET: Water/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var water = await _context.Water
                .FirstOrDefaultAsync(m => m.Id == id);
            if (water == null)
            {
                return NotFound();
            }

            return View(water);
        }

        // POST: Water/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var water = await _context.Water.FindAsync(id);
            if (water != null)
            {
                _context.Water.Remove(water);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WaterExists(int id)
        {
            return _context.Water.Any(e => e.Id == id);
        }
    }
}
