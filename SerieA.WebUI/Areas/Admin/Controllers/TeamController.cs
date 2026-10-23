using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using SerieA.WebUI.Areas.Admin.Models.TeamModels;
using SerieA.WebUI.ViewModels;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SerieA.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeamController : Controller
    {
        
        public async Task<IActionResult> Index()
        {
            using HttpClient client = new HttpClient();

            var response = await client.GetAsync("https://localhost:7278/api/admin/Teams");
            if (!response.IsSuccessStatusCode)
            {
                return View(new List<TeamListViewModel>());
            }
            var data= await response.Content.ReadFromJsonAsync<List<TeamListViewModel>>();
            return View(data);
        }


        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            using HttpClient client = new HttpClient();

            var response = await client.GetAsync($"https://localhost:7278/api/admin/Teams/id?id={id}");
            if (!response.IsSuccessStatusCode)
            {
                return View(new List<TeamListViewModel>());
            }
            var data = await response.Content.ReadFromJsonAsync<List<TeamListViewModel>>();
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateTeamViewModel updateTeamViewModel)
        {
            using HttpClient client = new HttpClient();

            var response = await client.GetAsync("https://localhost:7278/api/admin/Teams");
          
           return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            using HttpClient client = new HttpClient();

            var response = await client.GetAsync("https://localhost:7278/api/admin/Teams");
            if (!response.IsSuccessStatusCode)
            {
                return View(new List<TeamListViewModel>());
            }
            var data = await response.Content.ReadFromJsonAsync<List<TeamListViewModel>>();
            return View(data);
        }


        [HttpPost]
        public async Task<IActionResult> Create(CreateTeamViewModel createTeamViewModel)
        {
            using HttpClient client = new HttpClient();

            var response = await client.GetAsync("https://localhost:7278/api/admin/Teams");
            if (!response.IsSuccessStatusCode)
            {
                return View(new List<TeamListViewModel>());
            }
            var data = await response.Content.ReadFromJsonAsync<List<TeamListViewModel>>();
            return View(data);
        }
    }
}
