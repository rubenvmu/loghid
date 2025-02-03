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
    public class HydrocarbonsController : Controller
    {
        private readonly LoghidDbContext _context;

        public HydrocarbonsController(LoghidDbContext context)
        {
            _context = context;
        }

        // GET: Hydrocarbons
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hydrocarbons.ToListAsync());
        }

        // GET: Hydrocarbons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hydrocarbons = await _context.Hydrocarbons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hydrocarbons == null)
            {
                return NotFound();
            }

            return View(hydrocarbons);
        }

        // GET: Hydrocarbons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hydrocarbons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsoThreshold,PemResultC2,PemResultC3,PemResultC4,PemResultC5,PemResultC6C18,Probability")] Hydrocarbons hydrocarbons)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hydrocarbons);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hydrocarbons);
        }

        // GET: Hydrocarbons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hydrocarbons = await _context.Hydrocarbons.FindAsync(id);
            if (hydrocarbons == null)
            {
                return NotFound();
            }
            return View(hydrocarbons);
        }

        // POST: Hydrocarbons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsoThreshold,PemResultC2,PemResultC3,PemResultC4,PemResultC5,PemResultC6C18,Probability")] Hydrocarbons hydrocarbons)
        {
            if (id != hydrocarbons.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hydrocarbons);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HydrocarbonsExists(hydrocarbons.Id))
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
            return View(hydrocarbons);
        }

        // GET: Hydrocarbons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hydrocarbons = await _context.Hydrocarbons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hydrocarbons == null)
            {
                return NotFound();
            }

            return View(hydrocarbons);
        }

        // POST: Hydrocarbons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hydrocarbons = await _context.Hydrocarbons.FindAsync(id);
            if (hydrocarbons != null)
            {
                _context.Hydrocarbons.Remove(hydrocarbons);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HydrocarbonsExists(int id)
        {
            return _context.Hydrocarbons.Any(e => e.Id == id);
        }
    }
}
