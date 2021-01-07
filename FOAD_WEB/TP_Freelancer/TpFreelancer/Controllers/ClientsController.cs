using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TpFreelancer.Models;

namespace TpFreelancer.Controllers
{
    public class ClientsController : Controller
    {
        public IActionResult Index()
        {
            Client client = new Client
            {
                ClientId = 1,
                Nom = "Katty",
                Email = "kat@mail.com"

            };

            return View();
        }
    }
}
