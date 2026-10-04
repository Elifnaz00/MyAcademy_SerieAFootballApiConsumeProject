using Microsoft.AspNetCore.Mvc;

namespace SerieA.WebUI.Controllers
{
    public class MatchController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }


        public async Task<IActionResult> Detail()
        {
            return View();
        }
    }
}
