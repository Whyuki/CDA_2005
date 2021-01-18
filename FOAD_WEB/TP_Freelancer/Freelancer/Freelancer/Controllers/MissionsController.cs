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
    public class MissionsController : Controller
    {
        private readonly MvcFreelancerContext _context;

        public MissionsController(MvcFreelancerContext context)
        {
            _context = context;
        }

        // GET: Missions
        public async Task<IActionResult> Index()
        {
            var missions = _context.Missions.Include(c => c.Client);
            if (missions.Any())
            {
            var missionsOrderByUpdated = missions.OrderBy(c => c.UpdatedAt);
                Mission lastMissionUpdated = missionsOrderByUpdated.Last();
                ViewData["lastMissionCreateUpdate"] = "Derniere mission ajoutée/modifiée : "+lastMissionUpdated.MissionId + " : " + lastMissionUpdated.Titre;
            }
            
            return View(await missions.ToListAsync());

        }

        // GET: Missions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var missions = _context.Missions.Include(c => c.Client);
            var mission = await missions.FirstOrDefaultAsync(m => m.MissionId == id);

            if (mission == null)
            {
                return NotFound();
            }

            return View(mission);
        }

        // GET: Missions/Create
        public IActionResult Create()
        {
            ViewData["listClients"] = new SelectList(_context.Clients, "ClientId", "Nom");
            return View();
        }

        // POST: Missions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MissionId,Etat,Titre,Debut,Fin,Description,ClientId,Montant")] MissionMontant mission)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mission);
                await _context.SaveChangesAsync();
                Devis devis = new Devis("proposé", DateTime.Now, mission.Montant, mission.MissionId);
                DevisController devisController = new DevisController(_context);
                await devisController.Create(devis);

                //return RedirectToAction(nameof(Index));
                return RedirectToAction("Details","Devis", new {id = devis.DevisId });
            }
            return View(mission);
        }

        // GET: Missions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewData["listClients"] = new SelectList(_context.Clients, "ClientId", "Nom");
            var mission = await _context.Missions.FindAsync(id);
            if (mission == null)
            {
                return NotFound();
            }
            return View(mission);
        }

        // POST: Missions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MissionId,Etat,Titre,Debut,Fin,Description,ClientId")] Mission mission)
        {
            if (id != mission.MissionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mission);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MissionExists(mission.MissionId))
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
            return View(mission);
        }

        // GET: Missions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var missions = _context.Missions.Include(c => c.Client);
            var mission = await missions.FirstOrDefaultAsync(m => m.MissionId == id);
            if (mission == null)
            {
                return NotFound();
            }

            return View(mission);
        }

        // POST: Missions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mission = await _context.Missions.FindAsync(id);
            _context.Missions.Remove(mission);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MissionExists(int id)
        {
            return _context.Missions.Any(e => e.MissionId == id);
        }
    }
}
