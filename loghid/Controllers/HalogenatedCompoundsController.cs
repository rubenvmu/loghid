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
    public class HalogenatedCompoundsController : Controller
    {
        private readonly LoghidDbContext _context;

        public HalogenatedCompoundsController(LoghidDbContext context)
        {
            _context = context;
        }

        // GET: HalogenatedCompounds
        public async Task<IActionResult> Index()
        {
            return View(await _context.HalogenatedCompounds.ToListAsync());
        }

        // GET: HalogenatedCompounds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var halogenatedCompounds = await _context.HalogenatedCompounds
                .FirstOrDefaultAsync(m => m.Id == id);
            if (halogenatedCompounds == null)
            {
                return NotFound();
            }

            return View(halogenatedCompounds);
        }

        // GET: HalogenatedCompounds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HalogenatedCompounds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsoThreshold,PemResult,Probability")] HalogenatedCompounds halogenatedCompounds)
        {
            if (ModelState.IsValid)
            {
                _context.Add(halogenatedCompounds);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(halogenatedCompounds);
        }

        // GET: HalogenatedCompounds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var halogenatedCompounds = await _context.HalogenatedCompounds.FindAsync(id);
            if (halogenatedCompounds == null)
            {
                return NotFound();
            }
            return View(halogenatedCompounds);
        }

        // POST: HalogenatedCompounds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsoThreshold,PemResult,Probability")] HalogenatedCompounds halogenatedCompounds)
        {
            if (id != halogenatedCompounds.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(halogenatedCompounds);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HalogenatedCompoundsExists(halogenatedCompounds.Id))
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
            return View(halogenatedCompounds);
        }

        // GET: HalogenatedCompounds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var halogenatedCompounds = await _context.HalogenatedCompounds
                .FirstOrDefaultAsync(m => m.Id == id);
            if (halogenatedCompounds == null)
            {
                return NotFound();
            }

            return View(halogenatedCompounds);
        }

        // POST: HalogenatedCompounds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var halogenatedCompounds = await _context.HalogenatedCompounds.FindAsync(id);
            if (halogenatedCompounds != null)
            {
                _context.HalogenatedCompounds.Remove(halogenatedCompounds);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HalogenatedCompoundsExists(int id)
        {
            return _context.HalogenatedCompounds.Any(e => e.Id == id);
        }
    }
}
