using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CapitoYuliana_ExamenProgreso1.Data;
using CapitoYuliana_ExamenProgreso1.Models;

namespace CapitoYuliana_ExamenProgreso1.Controllers
{
    public class CapitoController : Controller
    {
        private readonly CapitoYuliana_ExamenProgreso1Context _context;

        public CapitoController(CapitoYuliana_ExamenProgreso1Context context)
        {
            _context = context;
        }

        // GET: Capito
        public async Task<IActionResult> Index()
        {
            return View(await _context.Capito.ToListAsync());
        }

        // GET: Capito/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var capito = await _context.Capito
                .FirstOrDefaultAsync(m => m.Cedula == id);
            if (capito == null)
            {
                return NotFound();
            }

            return View(capito);
        }

        // GET: Capito/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Capito/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Cedula,Nombre,Email,Edad,Altura,MayorDeEdad,idCelular")] Capito capito)
        {
            if (ModelState.IsValid)
            {
                _context.Add(capito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(capito);
        }

        // GET: Capito/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var capito = await _context.Capito.FindAsync(id);
            if (capito == null)
            {
                return NotFound();
            }
            return View(capito);
        }

        // POST: Capito/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Cedula,Nombre,Email,Edad,Altura,MayorDeEdad,idCelular")] Capito capito)
        {
            if (id != capito.Cedula)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(capito);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CapitoExists(capito.Cedula))
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
            return View(capito);
        }

        // GET: Capito/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var capito = await _context.Capito
                .FirstOrDefaultAsync(m => m.Cedula == id);
            if (capito == null)
            {
                return NotFound();
            }

            return View(capito);
        }

        // POST: Capito/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var capito = await _context.Capito.FindAsync(id);
            if (capito != null)
            {
                _context.Capito.Remove(capito);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CapitoExists(int id)
        {
            return _context.Capito.Any(e => e.Cedula == id);
        }
    }
}
