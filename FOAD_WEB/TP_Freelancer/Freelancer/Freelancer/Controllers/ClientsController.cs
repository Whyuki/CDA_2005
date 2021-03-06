﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Freelancer.Data;
using Freelancer.Models;
using Microsoft.Data.SqlClient;

namespace Freelancer.Controllers
{
    public class ClientsController : Controller
    {
        private readonly MvcFreelancerContext _context;

        public ClientsController(MvcFreelancerContext context)
        {
            _context = context;
        }

        // GET: Clients
        public async Task<IActionResult> Index()
        {
            //return View(await _context.Clients.ToListAsync());
            var clients = _context.Clients.Include(c => c.Categorie);
            if (clients.Any())
            {
                var clientsOrderByUpdated = clients.OrderBy(c => c.UpdatedAt);
                Client lastClientUpdated = clientsOrderByUpdated.Last();
                ViewData["lastClientCreateUpdate"] = "Dernier client ajouté/modifié : " + lastClientUpdated.Nom;
            }
            return View(await clients.ToListAsync());
        }

        // GET: Clients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var clients = _context.Clients.Include(c => c.Categorie);
            var client = await clients.FirstOrDefaultAsync(m => m.ClientId == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // GET: Clients/Create
        public IActionResult Create()
        {
            ViewData["listCats"] = new SelectList(_context.CategoriesClient, "CategorieId", "Nom");
            return View();
        }

        // POST: Clients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClientId,Nom,Email,CategorieClientId")] Client client)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    _context.Add(client);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException)
                {
                    ModelState.AddModelError("Email", "Cette adresse mail existe déjà");
                    return View(client);
                }
            }
            ViewData["listCats"] = new SelectList(_context.CategoriesClient, "CategorieId", "Nom", client.ClientId);

            return View(client);
        }

        // GET: Clients/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewData["listCats"] = new SelectList(_context.CategoriesClient, "CategorieId", "Nom");
            var client = await _context.Clients.FindAsync(id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        // POST: Clients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClientId,Nom,Email,CategorieClientId")] Client client)
        {
            if (id != client.ClientId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(client);
                    _context.Entry(client).Property(x => x.CreatedAt).IsModified = false;

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientExists(client.ClientId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                catch (DbUpdateException e)
                {
                    if (e.InnerException.Message.Contains("Nom"))
                    {
                        ModelState.AddModelError("Nom", "Un client portant ce nom existe déjà");

                    }
                    if (e.InnerException.Message.Contains("Email"))
                    {
                        ModelState.AddModelError("Email", "Cette adresse mail est déjà rattachée à un client");
                    }

                    ViewData["listCats"] = new SelectList(_context.CategoriesClient, "CategorieId", "Nom", client.ClientId);
                    return View(client);
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["listCats"] = new SelectList(_context.CategoriesClient, "CategorieId", "Nom", client.ClientId);

            return View(client);
        }

        // GET: Clients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clients = _context.Clients.Include(c => c.Categorie);
            var client = await clients.FirstOrDefaultAsync(m => m.ClientId == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientExists(int id)
        {
            return _context.Clients.Any(e => e.ClientId == id);
        }
    }
}
