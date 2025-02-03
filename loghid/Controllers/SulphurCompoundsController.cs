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
    public class SulphurCompoundsController : Controller
    {
        private readonly LoghidDbContext _context;

        public SulphurCompoundsController(LoghidDbContext context)
        {
            _context = context;
        }

        // GET: SulphurCompounds
        public async Task<IActionResult> Index()
        {
            return View(await _context.SulphurCompounds.ToListAsync());
        }

        // GET: SulphurCompounds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sulphurCompounds = await _context.SulphurCompounds
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sulphurCompounds == null)
            {
                return NotFound();
            }

            return View(sulphurCompounds);
        }

        // GET: SulphurCompounds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SulphurCompounds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsoThreshold,PemResult,Probability")] SulphurCompounds sulphurCompounds)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sulphurCompounds);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sulphurCompounds);
        }

        // GET: SulphurCompounds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sulphurCompounds = await _context.SulphurCompounds.FindAsync(id);
            if (sulphurCompounds == null)
            {
                return NotFound();
            }
            return View(sulphurCompounds);
        }

        // POST: SulphurCompounds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsoThreshold,PemResult,Probability")] SulphurCompounds sulphurCompounds)
        {
            if (id != sulphurCompounds.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sulphurCompounds);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SulphurCompoundsExists(sulphurCompounds.Id))
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
            return View(sulphurCompounds);
        }

        // GET: SulphurCompounds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sulphurCompounds = await _context.SulphurCompounds
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sulphurCompounds == null)
            {
                return NotFound();
            }

            return View(sulphurCompounds);
        }

        // POST: SulphurCompounds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sulphurCompounds = await _context.SulphurCompounds.FindAsync(id);
            if (sulphurCompounds != null)
            {
                _context.SulphurCompounds.Remove(sulphurCompounds);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SulphurCompoundsExists(int id)
        {
            return _context.SulphurCompounds.Any(e => e.Id == id);
        }
    }
}
