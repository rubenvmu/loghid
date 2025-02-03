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
    public class AmmoniaController : Controller
    {
        private readonly LoghidDbContext _context;

        public AmmoniaController(LoghidDbContext context)
        {
            _context = context;
        }

        // GET: Ammonia
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ammonia.ToListAsync());
        }

        // GET: Ammonia/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ammonia = await _context.Ammonia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ammonia == null)
            {
                return NotFound();
            }

            return View(ammonia);
        }

        // GET: Ammonia/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ammonia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsoThreshold,PemResult,Probability")] Ammonia ammonia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ammonia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ammonia);
        }

        // GET: Ammonia/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ammonia = await _context.Ammonia.FindAsync(id);
            if (ammonia == null)
            {
                return NotFound();
            }
            return View(ammonia);
        }

        // POST: Ammonia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsoThreshold,PemResult,Probability")] Ammonia ammonia)
        {
            if (id != ammonia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ammonia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AmmoniaExists(ammonia.Id))
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
            return View(ammonia);
        }

        // GET: Ammonia/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ammonia = await _context.Ammonia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ammonia == null)
            {
                return NotFound();
            }

            return View(ammonia);
        }

        // POST: Ammonia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ammonia = await _context.Ammonia.FindAsync(id);
            if (ammonia != null)
            {
                _context.Ammonia.Remove(ammonia);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AmmoniaExists(int id)
        {
            return _context.Ammonia.Any(e => e.Id == id);
        }
    }
}
