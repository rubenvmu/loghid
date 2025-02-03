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
    public class NonCH4HydrocarbonsController : Controller
    {
        private readonly LoghidDbContext _context;

        public NonCH4HydrocarbonsController(LoghidDbContext context)
        {
            _context = context;
        }

        // GET: NonCH4Hydrocarbons
        public async Task<IActionResult> Index()
        {
            return View(await _context.NonCH4Hydrocarbons.ToListAsync());
        }

        // GET: NonCH4Hydrocarbons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nonCH4Hydrocarbons = await _context.NonCH4Hydrocarbons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nonCH4Hydrocarbons == null)
            {
                return NotFound();
            }

            return View(nonCH4Hydrocarbons);
        }

        // GET: NonCH4Hydrocarbons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NonCH4Hydrocarbons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsoThreshold,PemResultMin,PemResultMax,Probability")] NonCH4Hydrocarbons nonCH4Hydrocarbons)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nonCH4Hydrocarbons);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nonCH4Hydrocarbons);
        }

        // GET: NonCH4Hydrocarbons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nonCH4Hydrocarbons = await _context.NonCH4Hydrocarbons.FindAsync(id);
            if (nonCH4Hydrocarbons == null)
            {
                return NotFound();
            }
            return View(nonCH4Hydrocarbons);
        }

        // POST: NonCH4Hydrocarbons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsoThreshold,PemResultMin,PemResultMax,Probability")] NonCH4Hydrocarbons nonCH4Hydrocarbons)
        {
            if (id != nonCH4Hydrocarbons.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nonCH4Hydrocarbons);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NonCH4HydrocarbonsExists(nonCH4Hydrocarbons.Id))
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
            return View(nonCH4Hydrocarbons);
        }

        // GET: NonCH4Hydrocarbons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nonCH4Hydrocarbons = await _context.NonCH4Hydrocarbons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nonCH4Hydrocarbons == null)
            {
                return NotFound();
            }

            return View(nonCH4Hydrocarbons);
        }

        // POST: NonCH4Hydrocarbons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nonCH4Hydrocarbons = await _context.NonCH4Hydrocarbons.FindAsync(id);
            if (nonCH4Hydrocarbons != null)
            {
                _context.NonCH4Hydrocarbons.Remove(nonCH4Hydrocarbons);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NonCH4HydrocarbonsExists(int id)
        {
            return _context.NonCH4Hydrocarbons.Any(e => e.Id == id);
        }
    }
}
