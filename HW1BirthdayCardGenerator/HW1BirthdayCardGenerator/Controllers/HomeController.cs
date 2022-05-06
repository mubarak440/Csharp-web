using HW1BirthdayCardGenerator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HW1BirthdayCardGenerator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult InviteForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InviteForm(CardGenerator cardInformation)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", cardInformation);
            }
            else // stay in the page if the error validation pops on the page
            {
                return View();
            }


        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}