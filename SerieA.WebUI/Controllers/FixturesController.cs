using Microsoft.AspNetCore.Mvc;

namespace SerieA.WebUI.Controllers
{
    public class FixturesController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
