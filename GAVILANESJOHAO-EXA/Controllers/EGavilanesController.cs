using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GAVILANESJOHAO_EXAMEN.Models;

namespace GAVILANESJOHAO_EXA.Controllers
{
    public class EGavilanesController : Controller
    {
        private readonly GAVILANESJOHAO_EXAContext _context;

        public EGavilanesController(GAVILANESJOHAO_EXAContext context)
        {
            _context = context;
        }

        // GET: EGavilanes
        public async Task<IActionResult> Index()
        {
            var gAVILANESJOHAO_EXAContext = _context.EGavilanes.Include(e => e.Celular);
            return View(await gAVILANESJOHAO_EXAContext.ToListAsync());
        }

        // GET: EGavilanes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eGavilanes = await _context.EGavilanes
                .Include(e => e.Celular)
                .FirstOrDefaultAsync(m => m.Nombre == id);
            if (eGavilanes == null)
            {
                return NotFound();
            }

            return View(eGavilanes);
        }

        // GET: EGavilanes/Create
        public IActionResult Create()
        {
            ViewData["IdCelular"] = new SelectList(_context.Set<Celular>(), "IdCelular", "NombreModelo");
            return View();
        }

        // POST: EGavilanes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nombre,Fecha,cedula,peso,NacionalEcuatoriano,IdCelular")] EGavilanes eGavilanes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eGavilanes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCelular"] = new SelectList(_context.Set<Celular>(), "IdCelular", "NombreModelo", eGavilanes.IdCelular);
            return View(eGavilanes);
        }

        // GET: EGavilanes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eGavilanes = await _context.EGavilanes.FindAsync(id);
            if (eGavilanes == null)
            {
                return NotFound();
            }
            ViewData["IdCelular"] = new SelectList(_context.Set<Celular>(), "IdCelular", "NombreModelo", eGavilanes.IdCelular);
            return View(eGavilanes);
        }

        // POST: EGavilanes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Nombre,Fecha,cedula,peso,NacionalEcuatoriano,IdCelular")] EGavilanes eGavilanes)
        {
            if (id != eGavilanes.Nombre)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eGavilanes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EGavilanesExists(eGavilanes.Nombre))
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
            ViewData["IdCelular"] = new SelectList(_context.Set<Celular>(), "IdCelular", "NombreModelo", eGavilanes.IdCelular);
            return View(eGavilanes);
        }

        // GET: EGavilanes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eGavilanes = await _context.EGavilanes
                .Include(e => e.Celular)
                .FirstOrDefaultAsync(m => m.Nombre == id);
            if (eGavilanes == null)
            {
                return NotFound();
            }

            return View(eGavilanes);
        }

        // POST: EGavilanes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var eGavilanes = await _context.EGavilanes.FindAsync(id);
            if (eGavilanes != null)
            {
                _context.EGavilanes.Remove(eGavilanes);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EGavilanesExists(string id)
        {
            return _context.EGavilanes.Any(e => e.Nombre == id);
        }
    }
}
