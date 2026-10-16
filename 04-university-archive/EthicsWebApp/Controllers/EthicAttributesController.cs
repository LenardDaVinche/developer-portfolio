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
    public class EthicAttributesController : Controller
    {
        private readonly EthicsWebAppContext _context;

        public EthicAttributesController(EthicsWebAppContext context)
        {
            _context = context;
        }

        // GET: EthicAttributes
        public async Task<IActionResult> Index()
        {
              return _context.EthicAttribute != null ? 
                          View(await _context.EthicAttribute.ToListAsync()) :
                          Problem("Entity set 'EthicsWebAppContext.EthicAttribute'  is null.");
        }

        // GET: EthicAttributes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.EthicAttribute == null)
            {
                return NotFound();
            }

            var ethicAttribute = await _context.EthicAttribute
                .FirstOrDefaultAsync(m => m.AttrID == id);
            if (ethicAttribute == null)
            {
                return NotFound();
            }

            return View(ethicAttribute);
        }

        // GET: EthicAttributes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EthicAttributes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AttrID,Type,Data")] EthicAttribute ethicAttribute)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ethicAttribute);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ethicAttribute);
        }

        // GET: EthicAttributes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.EthicAttribute == null)
            {
                return NotFound();
            }

            var ethicAttribute = await _context.EthicAttribute.FindAsync(id);
            if (ethicAttribute == null)
            {
                return NotFound();
            }
            return View(ethicAttribute);
        }

        // POST: EthicAttributes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AttrID,Type,Data")] EthicAttribute ethicAttribute)
        {
            if (id != ethicAttribute.AttrID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ethicAttribute);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EthicAttributeExists(ethicAttribute.AttrID))
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
            return View(ethicAttribute);
        }

        // GET: EthicAttributes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.EthicAttribute == null)
            {
                return NotFound();
            }

            var ethicAttribute = await _context.EthicAttribute
                .FirstOrDefaultAsync(m => m.AttrID == id);
            if (ethicAttribute == null)
            {
                return NotFound();
            }

            return View(ethicAttribute);
        }

        // POST: EthicAttributes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.EthicAttribute == null)
            {
                return Problem("Entity set 'EthicsWebAppContext.EthicAttribute'  is null.");
            }
            var ethicAttribute = await _context.EthicAttribute.FindAsync(id);
            if (ethicAttribute != null)
            {
                _context.EthicAttribute.Remove(ethicAttribute);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EthicAttributeExists(int id)
        {
          return (_context.EthicAttribute?.Any(e => e.AttrID == id)).GetValueOrDefault();
        }
    }
}
