using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EthicsWebApp.Data;
using EthicsWebApp.Models;

namespace EthicsWebApp.Controllers
{
    public class VariablesController : Controller
    {
        private readonly EthicsWebAppContext _context;

        public VariablesController(EthicsWebAppContext context)
        {
            _context = context;
        }

        // GET: Variables
        public async Task<IActionResult> Index()
        {
              return _context.Variable != null ? 
                          View(await _context.Variable.ToListAsync()) :
                          Problem("Entity set 'EthicsWebAppContext.Variable'  is null.");
        }

        // GET: Variables/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Variable == null)
            {
                return NotFound();
            }

            var variable = await _context.Variable
                .FirstOrDefaultAsync(m => m.VarID == id);
            if (variable == null)
            {
                return NotFound();
            }

            return View(variable);
        }

        // GET: Variables/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Variables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VarID,Name,Desc")] Variable variable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(variable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(variable);
        }

        // GET: Variables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Variable == null)
            {
                return NotFound();
            }

            var variable = await _context.Variable.FindAsync(id);
            if (variable == null)
            {
                return NotFound();
            }
            return View(variable);
        }

        // POST: Variables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VarID,Name,Desc")] Variable variable)
        {
            if (id != variable.VarID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(variable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VariableExists(variable.VarID))
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
            return View(variable);
        }

        // GET: Variables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Variable == null)
            {
                return NotFound();
            }

            var variable = await _context.Variable
                .FirstOrDefaultAsync(m => m.VarID == id);
            if (variable == null)
            {
                return NotFound();
            }

            return View(variable);
        }

        // POST: Variables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Variable == null)
            {
                return Problem("Entity set 'EthicsWebAppContext.Variable'  is null.");
            }
            var variable = await _context.Variable.FindAsync(id);
            if (variable != null)
            {
                _context.Variable.Remove(variable);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VariableExists(int id)
        {
          return (_context.Variable?.Any(e => e.VarID == id)).GetValueOrDefault();
        }
    }
}
