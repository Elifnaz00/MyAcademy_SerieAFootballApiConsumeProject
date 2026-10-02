using Microsoft.AspNetCore.Mvc;

namespace SerieA.WebUI.Controllers
{
    public class StandingController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
