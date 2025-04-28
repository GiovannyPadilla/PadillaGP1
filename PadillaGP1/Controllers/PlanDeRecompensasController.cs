using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PadillaGP1.Data;
using PadillaGP1.Models;

namespace PadillaGP1.Controllers
{
    public class PlanDeRecompensasController : Controller
    {
        private readonly PadillaGP1Context _context;

        public PlanDeRecompensasController(PadillaGP1Context context)
        {
            _context = context;
        }

        // GET: PlanDeRecompensas
        public async Task<IActionResult> Index()
        {
            return View(await _context.PlanDeRecompensas.ToListAsync());
        }

        // GET: PlanDeRecompensas/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planDeRecompensas = await _context.PlanDeRecompensas
                .FirstOrDefaultAsync(m => m.id == id);
            if (planDeRecompensas == null)
            {
                return NotFound();
            }

            return View(planDeRecompensas);
        }

        // GET: PlanDeRecompensas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PlanDeRecompensas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nombre,fechaInicio,puntosAcumulados,tipoRecompensa")] PlanDeRecompensas planDeRecompensas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(planDeRecompensas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(planDeRecompensas);
        }

        // GET: PlanDeRecompensas/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planDeRecompensas = await _context.PlanDeRecompensas.FindAsync(id);
            if (planDeRecompensas == null)
            {
                return NotFound();
            }
            return View(planDeRecompensas);
        }

        // POST: PlanDeRecompensas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("id,nombre,fechaInicio,puntosAcumulados,tipoRecompensa")] PlanDeRecompensas planDeRecompensas)
        {
            if (id != planDeRecompensas.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planDeRecompensas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlanDeRecompensasExists(planDeRecompensas.id))
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
            return View(planDeRecompensas);
        }

        // GET: PlanDeRecompensas/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planDeRecompensas = await _context.PlanDeRecompensas
                .FirstOrDefaultAsync(m => m.id == id);
            if (planDeRecompensas == null)
            {
                return NotFound();
            }

            return View(planDeRecompensas);
        }

        // POST: PlanDeRecompensas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var planDeRecompensas = await _context.PlanDeRecompensas.FindAsync(id);
            if (planDeRecompensas != null)
            {
                _context.PlanDeRecompensas.Remove(planDeRecompensas);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlanDeRecompensasExists(string id)
        {
            return _context.PlanDeRecompensas.Any(e => e.id == id);
        }
    }
}
