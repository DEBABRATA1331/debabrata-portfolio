using Microsoft.AspNetCore.Mvc;

namespace PORTFOLIOWEBSITE.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index() => View();
        public IActionResult About() => View();
        public IActionResult Projects() => View();
        
    }
}
