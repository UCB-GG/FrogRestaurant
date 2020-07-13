using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Common.Models;
using FrogRestaurant.Common.Application;
using WebApiService;

namespace FrogRestaurant.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        private PersonManager personManager;
        public HomeController(ILogger<HomeController> logger,
                              WebServiceFactory factory)
        {
            _logger = logger;
            personManager = new PersonManager(factory);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(personManager.GetPersonsAsync());
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
