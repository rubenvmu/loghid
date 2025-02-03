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
    public class FormicAcidController : Controller
    {
        private readonly LoghidDbContext _context;

        public FormicAcidController(LoghidDbContext context)
        {
            _context = context;
        }

        // GET: FormicAcid
        public async Task<IActionResult> Index()
        {
            return View(await _context.FormicAcid.ToListAsync());
        }

        // GET: FormicAcid/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formicAcid = await _context.FormicAcid
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formicAcid == null)
            {
                return NotFound();
            }

            return View(formicAcid);
        }

        // GET: FormicAcid/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FormicAcid/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsoThreshold,PemResult,Probability")] FormicAcid formicAcid)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formicAcid);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formicAcid);
        }

        // GET: FormicAcid/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formicAcid = await _context.FormicAcid.FindAsync(id);
            if (formicAcid == null)
            {
                return NotFound();
            }
            return View(formicAcid);
        }

        // POST: FormicAcid/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsoThreshold,PemResult,Probability")] FormicAcid formicAcid)
        {
            if (id != formicAcid.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formicAcid);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormicAcidExists(formicAcid.Id))
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
            return View(formicAcid);
        }

        // GET: FormicAcid/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formicAcid = await _context.FormicAcid
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formicAcid == null)
            {
                return NotFound();
            }

            return View(formicAcid);
        }

        // POST: FormicAcid/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formicAcid = await _context.FormicAcid.FindAsync(id);
            if (formicAcid != null)
            {
                _context.FormicAcid.Remove(formicAcid);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormicAcidExists(int id)
        {
            return _context.FormicAcid.Any(e => e.Id == id);
        }
    }
}
