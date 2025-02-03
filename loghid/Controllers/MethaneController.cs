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
    public class MethaneController : Controller
    {
        private readonly LoghidDbContext _context;

        public MethaneController(LoghidDbContext context)
        {
            _context = context;
        }

        // GET: Methane
        public async Task<IActionResult> Index()
        {
            return View(await _context.Methane.ToListAsync());
        }

        // GET: Methane/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var methane = await _context.Methane
                .FirstOrDefaultAsync(m => m.Id == id);
            if (methane == null)
            {
                return NotFound();
            }

            return View(methane);
        }

        // GET: Methane/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Methane/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsoThreshold,PemResult,Probability")] Methane methane)
        {
            if (ModelState.IsValid)
            {
                _context.Add(methane);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(methane);
        }

        // GET: Methane/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var methane = await _context.Methane.FindAsync(id);
            if (methane == null)
            {
                return NotFound();
            }
            return View(methane);
        }

        // POST: Methane/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsoThreshold,PemResult,Probability")] Methane methane)
        {
            if (id != methane.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(methane);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MethaneExists(methane.Id))
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
            return View(methane);
        }

        // GET: Methane/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var methane = await _context.Methane
                .FirstOrDefaultAsync(m => m.Id == id);
            if (methane == null)
            {
                return NotFound();
            }

            return View(methane);
        }

        // POST: Methane/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var methane = await _context.Methane.FindAsync(id);
            if (methane != null)
            {
                _context.Methane.Remove(methane);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MethaneExists(int id)
        {
            return _context.Methane.Any(e => e.Id == id);
        }
    }
}
