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
    public class NitrogenController : Controller
    {
        private readonly LoghidDbContext _context;

        public NitrogenController(LoghidDbContext context)
        {
            _context = context;
        }

        // GET: Nitrogen
        public async Task<IActionResult> Index()
        {
            return View(await _context.Nitrogen.ToListAsync());
        }

        // GET: Nitrogen/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nitrogen = await _context.Nitrogen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nitrogen == null)
            {
                return NotFound();
            }

            return View(nitrogen);
        }

        // GET: Nitrogen/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Nitrogen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsoThreshold,PemResultMin,PemResultMax,Probability")] Nitrogen nitrogen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nitrogen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nitrogen);
        }

        // GET: Nitrogen/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nitrogen = await _context.Nitrogen.FindAsync(id);
            if (nitrogen == null)
            {
                return NotFound();
            }
            return View(nitrogen);
        }

        // POST: Nitrogen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsoThreshold,PemResultMin,PemResultMax,Probability")] Nitrogen nitrogen)
        {
            if (id != nitrogen.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nitrogen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NitrogenExists(nitrogen.Id))
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
            return View(nitrogen);
        }

        // GET: Nitrogen/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nitrogen = await _context.Nitrogen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nitrogen == null)
            {
                return NotFound();
            }

            return View(nitrogen);
        }

        // POST: Nitrogen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nitrogen = await _context.Nitrogen.FindAsync(id);
            if (nitrogen != null)
            {
                _context.Nitrogen.Remove(nitrogen);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NitrogenExists(int id)
        {
            return _context.Nitrogen.Any(e => e.Id == id);
        }
    }
}
