using Microsoft.AspNetCore.Mvc;
using PORTFOLIOWEBSITE.Models;
using System.Diagnostics;

namespace PORTFOLIOWEBSITE.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View(); 
        }

        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult Skills()
        {
            return View();
        }

        public IActionResult Achievments()
        {
            return View();
        }

        public IActionResult Internship()
        {
            return View();
        }

        public IActionResult Contact()
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
