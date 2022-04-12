using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Spacentar.Data;

namespace Spacentar.Controllers
{
    public class ProgramNamesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProgramNamesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProgramNames
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProgramNames.ToListAsync());
        }

        // GET: ProgramNames/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programName = await _context.ProgramNames
                .FirstOrDefaultAsync(m => m.Id == id);
            if (programName == null)
            {
                return NotFound();
            }

            return View(programName);
        }

        // GET: ProgramNames/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProgramNames/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] ProgramName programName)
        {
            if (ModelState.IsValid)
            {
                _context.Add(programName);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(programName);
        }

        // GET: ProgramNames/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programName = await _context.ProgramNames.FindAsync(id);
            if (programName == null)
            {
                return NotFound();
            }
            return View(programName);
        }

        // POST: ProgramNames/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] ProgramName programName)
        {
            if (id != programName.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(programName);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProgramNameExists(programName.Id))
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
            return View(programName);
        }

        // GET: ProgramNames/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programName = await _context.ProgramNames
                .FirstOrDefaultAsync(m => m.Id == id);
            if (programName == null)
            {
                return NotFound();
            }

            return View(programName);
        }

        // POST: ProgramNames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var programName = await _context.ProgramNames.FindAsync(id);
            _context.ProgramNames.Remove(programName);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProgramNameExists(int id)
        {
            return _context.ProgramNames.Any(e => e.Id == id);
        }
    }
}
