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
    public class ScenariosController : Controller
    {
        private readonly EthicsWebAppContext _context;

        public ScenariosController(EthicsWebAppContext context)
        {
            _context = context;
        }

        // GET: Scenarios
        public async Task<IActionResult> Index()
        {
              return _context.Scenario != null ? 
                          View(await _context.Scenario.ToListAsync()) :
                          Problem("Entity set 'EthicsWebAppContext.Scenario'  is null.");
        }

        // GET: Scenarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Scenario == null)
            {
                return NotFound();
            }

            var scenario = await _context.Scenario
                .FirstOrDefaultAsync(m => m.SceID == id);
            if (scenario == null)
            {
                return NotFound();
            }

            return View(scenario);
        }

        // GET: Scenarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Scenarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SceID,Background,Var1,Var2,Attr1,Attr2")] Scenario scenario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(scenario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(scenario);
        }

        // GET: Scenarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Scenario == null)
            {
                return NotFound();
            }

            var scenario = await _context.Scenario.FindAsync(id);
            if (scenario == null)
            {
                return NotFound();
            }
            return View(scenario);
        }

        // POST: Scenarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SceID,Background,Var1,Var2,Attr1,Attr2")] Scenario scenario)
        {
            if (id != scenario.SceID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scenario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScenarioExists(scenario.SceID))
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
            return View(scenario);
        }

        // GET: Scenarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Scenario == null)
            {
                return NotFound();
            }

            var scenario = await _context.Scenario
                .FirstOrDefaultAsync(m => m.SceID == id);
            if (scenario == null)
            {
                return NotFound();
            }

            return View(scenario);
        }

        // POST: Scenarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Scenario == null)
            {
                return Problem("Entity set 'EthicsWebAppContext.Scenario'  is null.");
            }
            var scenario = await _context.Scenario.FindAsync(id);
            if (scenario != null)
            {
                _context.Scenario.Remove(scenario);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScenarioExists(int id)
        {
          return (_context.Scenario?.Any(e => e.SceID == id)).GetValueOrDefault();
        }
    }
}
