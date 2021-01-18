using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Freelancer.Data;
using Freelancer.Models;

namespace Freelancer.Controllers
{
    public class CategorieClientsController : Controller
    {
        private readonly MvcFreelancerContext _context;

        public CategorieClientsController(MvcFreelancerContext context)
        {
            _context = context;
        }

        // GET: CategorieClients
        public async Task<IActionResult> Index()
        {
            var catClient = _context.CategoriesClient;
            if (catClient.Any())
            {
                var catClientOrderByUpdated = catClient.OrderBy(c => c.UpdatedAt);
                CategorieClient lastCatClientUpdated = catClientOrderByUpdated.Last();
                ViewData["lastCatClientCreateUpdate"] = "Derniere catégorie de client ajoutée/modifiée : "+lastCatClientUpdated.Nom;
            }
            return View(await catClient.ToListAsync());
        }

        // GET: CategorieClients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categorieClient = await _context.CategoriesClient
                .FirstOrDefaultAsync(m => m.CategorieId == id);
            if (categorieClient == null)
            {
                return NotFound();
            }

            return View(categorieClient);
        }

        // GET: CategorieClients/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CategorieClients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategorieId,Nom,Description")] CategorieClient categorieClient)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categorieClient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categorieClient);
        }

        // GET: CategorieClients/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categorieClient = await _context.CategoriesClient.FindAsync(id);
            if (categorieClient == null)
            {
                return NotFound();
            }
            return View(categorieClient);
        }

        // POST: CategorieClients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategorieId,Nom,Description")] CategorieClient categorieClient)
        {
            if (id != categorieClient.CategorieId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categorieClient);
                    _context.Entry(categorieClient).Property(x => x.CreatedAt).IsModified = false;

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategorieClientExists(categorieClient.CategorieId))
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
            return View(categorieClient);
        }

        // GET: CategorieClients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categorieClient = await _context.CategoriesClient
                .FirstOrDefaultAsync(m => m.CategorieId == id);
            if (categorieClient == null)
            {
                return NotFound();
            }

            return View(categorieClient);
        }

        // POST: CategorieClients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categorieClient = await _context.CategoriesClient.FindAsync(id);
            _context.CategoriesClient.Remove(categorieClient);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategorieClientExists(int id)
        {
            return _context.CategoriesClient.Any(e => e.CategorieId == id);
        }
    }
}
