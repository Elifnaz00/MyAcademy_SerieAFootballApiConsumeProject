using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Newtonsoft.Json;
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
        public async Task<IActionResult> Detail(int id)
        {
            using HttpClient client = new HttpClient();

            var response = await client.GetAsync($"https://localhost:7278/api/admin/Teams/{id}");
            if (!response.IsSuccessStatusCode)
            {
                return View(new TeamViewModel());
            }
            var data = await response.Content.ReadFromJsonAsync<TeamViewModel>();
            return View(data);
        }


        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            using HttpClient client = new HttpClient();

            var response = await client.GetAsync($"https://localhost:7278/api/admin/Teams/{id}");
            if (!response.IsSuccessStatusCode)
            {
                return View(new UpdateTeamViewModel());
            }
            var data = await response.Content.ReadFromJsonAsync<UpdateTeamViewModel>();
            if (data is null)
                return NotFound();

            return View(data);
        }


        [HttpPost]
        public async Task<IActionResult> Update(UpdateTeamViewModel updateTeamViewModel)
        {
            if (!ModelState.IsValid) 
                return View(updateTeamViewModel);
          

            using HttpClient client = new HttpClient();
             

            var response = await client.PutAsJsonAsync($"https://localhost:7278/api/admin/teams/{updateTeamViewModel.Id}", updateTeamViewModel);

            if (!response.IsSuccessStatusCode) 
                return BadRequest("Takım güncellenemedi.");
            
           return RedirectToAction("Index");
        }

        public IActionResult Create() { return View(); }


        [HttpPost]
        public async Task<IActionResult> Create(CreateTeamViewModel createTeamViewModel)
        {
            if(!ModelState.IsValid)
                return View(createTeamViewModel);

            using HttpClient client = new HttpClient();

            var response= await client.PostAsJsonAsync("https://localhost:7278/api/admin/teams", createTeamViewModel);
            if (!response.IsSuccessStatusCode)
                return BadRequest("Takım eklenemedi.");

            return RedirectToAction("Index");
        }


      

       
    }
}
