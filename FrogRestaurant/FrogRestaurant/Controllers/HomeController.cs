using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FrogRestaurant.Models;
using FrogRestaurant.Classes.Factories;
using FrogRestaurant.Classes.Application;

namespace FrogRestaurant.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        private PersonManager personManager;
        public HomeController(ILogger<HomeController> logger,
                              IFactory factory)
        {
            _logger = logger;
            personManager = new PersonManager(factory);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(personManager.GetPersons());
        }

        [HttpGet]
        public IActionResult NewPerson()
        {

            return View();
        }

        [HttpPost]
        public IActionResult NewPerson(PersonViewModel person)
        {
            personManager.AddNewPerson(person);

            return RedirectToAction("Index");
        }

    }
}
