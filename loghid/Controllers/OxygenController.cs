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
    public class OxygenController : Controller
    {
        private readonly LoghidDbContext _context;

        public OxygenController(LoghidDbContext context)
        {
            _context = context;
        }

        // GET: Oxygen
        public async Task<IActionResult> Index()
        {
            return View(await _context.Oxygen.ToListAsync());
        }

        // GET: Oxygen/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oxygen = await _context.Oxygen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (oxygen == null)
            {
                return NotFound();
            }

            return View(oxygen);
        }

        // GET: Oxygen/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Oxygen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsoThreshold,PemResultMin,PemResultMax,Probability")] Oxygen oxygen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(oxygen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(oxygen);
        }

        // GET: Oxygen/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oxygen = await _context.Oxygen.FindAsync(id);
            if (oxygen == null)
            {
                return NotFound();
            }
            return View(oxygen);
        }

        // POST: Oxygen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsoThreshold,PemResultMin,PemResultMax,Probability")] Oxygen oxygen)
        {
            if (id != oxygen.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(oxygen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OxygenExists(oxygen.Id))
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
            return View(oxygen);
        }

        // GET: Oxygen/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oxygen = await _context.Oxygen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (oxygen == null)
            {
                return NotFound();
            }

            return View(oxygen);
        }

        // POST: Oxygen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var oxygen = await _context.Oxygen.FindAsync(id);
            if (oxygen != null)
            {
                _context.Oxygen.Remove(oxygen);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OxygenExists(int id)
        {
            return _context.Oxygen.Any(e => e.Id == id);
        }
    }
}
