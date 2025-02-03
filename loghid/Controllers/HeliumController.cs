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
    public class HeliumController : Controller
    {
        private readonly LoghidDbContext _context;

        public HeliumController(LoghidDbContext context)
        {
            _context = context;
        }

        // GET: Helium
        public async Task<IActionResult> Index()
        {
            return View(await _context.Helium.ToListAsync());
        }

        // GET: Helium/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var helium = await _context.Helium
                .FirstOrDefaultAsync(m => m.Id == id);
            if (helium == null)
            {
                return NotFound();
            }

            return View(helium);
        }

        // GET: Helium/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Helium/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsoThreshold,PemResultMin,PemResultMax,Probability")] Helium helium)
        {
            if (ModelState.IsValid)
            {
                _context.Add(helium);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(helium);
        }

        // GET: Helium/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var helium = await _context.Helium.FindAsync(id);
            if (helium == null)
            {
                return NotFound();
            }
            return View(helium);
        }

        // POST: Helium/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsoThreshold,PemResultMin,PemResultMax,Probability")] Helium helium)
        {
            if (id != helium.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(helium);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HeliumExists(helium.Id))
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
            return View(helium);
        }

        // GET: Helium/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var helium = await _context.Helium
                .FirstOrDefaultAsync(m => m.Id == id);
            if (helium == null)
            {
                return NotFound();
            }

            return View(helium);
        }

        // POST: Helium/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var helium = await _context.Helium.FindAsync(id);
            if (helium != null)
            {
                _context.Helium.Remove(helium);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HeliumExists(int id)
        {
            return _context.Helium.Any(e => e.Id == id);
        }
    }
}
