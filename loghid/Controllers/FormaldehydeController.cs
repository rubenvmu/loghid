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
    public class FormaldehydeController : Controller
    {
        private readonly LoghidDbContext _context;

        public FormaldehydeController(LoghidDbContext context)
        {
            _context = context;
        }

        // GET: Formaldehyde
        public async Task<IActionResult> Index()
        {
            return View(await _context.Formaldehyde.ToListAsync());
        }

        // GET: Formaldehyde/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaldehyde = await _context.Formaldehyde
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formaldehyde == null)
            {
                return NotFound();
            }

            return View(formaldehyde);
        }

        // GET: Formaldehyde/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Formaldehyde/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsoThreshold,PemResult,Probability")] Formaldehyde formaldehyde)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formaldehyde);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formaldehyde);
        }

        // GET: Formaldehyde/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaldehyde = await _context.Formaldehyde.FindAsync(id);
            if (formaldehyde == null)
            {
                return NotFound();
            }
            return View(formaldehyde);
        }

        // POST: Formaldehyde/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsoThreshold,PemResult,Probability")] Formaldehyde formaldehyde)
        {
            if (id != formaldehyde.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formaldehyde);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormaldehydeExists(formaldehyde.Id))
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
            return View(formaldehyde);
        }

        // GET: Formaldehyde/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaldehyde = await _context.Formaldehyde
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formaldehyde == null)
            {
                return NotFound();
            }

            return View(formaldehyde);
        }

        // POST: Formaldehyde/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formaldehyde = await _context.Formaldehyde.FindAsync(id);
            if (formaldehyde != null)
            {
                _context.Formaldehyde.Remove(formaldehyde);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormaldehydeExists(int id)
        {
            return _context.Formaldehyde.Any(e => e.Id == id);
        }
    }
}
