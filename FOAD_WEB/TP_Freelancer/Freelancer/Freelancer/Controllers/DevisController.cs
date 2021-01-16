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
    public class DevisController : Controller
    {
        private readonly MvcFreelancerContext _context;

        public DevisController(MvcFreelancerContext context)
        {
            _context = context;
        }

        // GET: Devis
        public async Task<IActionResult> Index()
        {
            var devis = _context.Devis.Include(c => c.Mission);
            return View(await devis.ToListAsync());
        }

        // GET: Devis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var listDevis = _context.Devis.Include(c => c.Mission).ThenInclude(c => c.Client).ThenInclude(c => c.Categorie);
            var devis = await listDevis.FirstOrDefaultAsync(m => m.DevisId == id);
            if (devis == null)
            {
                return NotFound();
            }

            return View(devis);
        }

        // GET: Devis/Create
        public IActionResult Create()
        {
            var listMissions = _context.Missions.Select(s => new
            {
                Text = s.MissionId + " (" + s.Titre + ")",
                Value = s.MissionId
            }).ToList();
            ViewData["listMissions"] = new SelectList(listMissions, "Value", "Text");
            return View();
        }

        // POST: Devis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DevisId,EtatDevis,Date,Montant,DevisDateFinale,MontantFinal,MissionId")] Devis devis)
        {
            if (ModelState.IsValid)
            {
                _context.Add(devis);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(devis);
        }

        // GET: Devis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listMissions = _context.Missions.Select(s => new
            {
                Text = s.MissionId + " (" + s.Titre+")",
                Value = s.MissionId
            }).ToList();
            ViewData["listMissions"] = new SelectList(listMissions, "Value", "Text");

            var devis = await _context.Devis.FindAsync(id);
            if (devis == null)
            {
                return NotFound();
            }
            return View(devis);
        }

        // POST: Devis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DevisId,EtatDevis,Date,Montant,DevisDateFinale,MontantFinal,MissionId")] Devis devis)
        {
            if (id != devis.DevisId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(devis);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DevisExists(devis.DevisId))
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
            return View(devis);
        }

        // GET: Devis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var listDevis = _context.Devis.Include(d => d.Mission).ThenInclude(d => d.Client).ThenInclude(d => d.Categorie);
            var devis = await listDevis.FirstOrDefaultAsync(d => d.DevisId == id);
            
            if (devis == null)
            {
                return NotFound();
            }

            return View(devis);
        }

        // POST: Devis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var devis = await _context.Devis.FindAsync(id);
            _context.Devis.Remove(devis);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DevisExists(int id)
        {
            return _context.Devis.Any(e => e.DevisId == id);
        }




        public async Task<IActionResult> Clients()
        {
            ViewData["listClientsFacture"] = new SelectList(_context.Clients, "ClientId", "Nom");

            //var devis = _context.Devis.Include(c => c.Mission).ThenInclude(c => c.Client).ThenInclude(c => c.Categorie);

            //return View(await devis.ToListAsync());
            var clients = _context.Clients.Include(c => c.Categorie);
            return View(await clients.ToListAsync());
        }

        public async Task<IActionResult> Facture(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listDevis = _context.Devis.Include(d => d.Mission).ThenInclude(d => d.Client).ThenInclude(d => d.Categorie);
            var devis = listDevis.Where(d => d.Mission.ClientId == id);

            if (devis == null)
            {
                return NotFound();
            }

            return View(await devis.ToListAsync());
        }


    }
}
