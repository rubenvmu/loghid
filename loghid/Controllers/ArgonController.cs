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
    public class ArgonController : Controller
    {
        private readonly LoghidDbContext _context;

        public ArgonController(LoghidDbContext context)
        {
            _context = context;
        }

        // GET: Argon
        public async Task<IActionResult> Index()
        {
            return View(await _context.Argon.ToListAsync());
        }

        // GET: Argon/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var argon = await _context.Argon
                .FirstOrDefaultAsync(m => m.Id == id);
            if (argon == null)
            {
                return NotFound();
            }

            return View(argon);
        }

        // GET: Argon/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Argon/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsoThreshold,PemResult,Probability")] Argon argon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(argon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(argon);
        }

        // GET: Argon/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var argon = await _context.Argon.FindAsync(id);
            if (argon == null)
            {
                return NotFound();
            }
            return View(argon);
        }

        // POST: Argon/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsoThreshold,PemResult,Probability")] Argon argon)
        {
            if (id != argon.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(argon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArgonExists(argon.Id))
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
            return View(argon);
        }

        // GET: Argon/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var argon = await _context.Argon
                .FirstOrDefaultAsync(m => m.Id == id);
            if (argon == null)
            {
                return NotFound();
            }

            return View(argon);
        }

        // POST: Argon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var argon = await _context.Argon.FindAsync(id);
            if (argon != null)
            {
                _context.Argon.Remove(argon);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArgonExists(int id)
        {
            return _context.Argon.Any(e => e.Id == id);
        }
    }
}
