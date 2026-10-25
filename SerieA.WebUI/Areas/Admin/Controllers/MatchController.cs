using Microsoft.AspNetCore.Mvc;
using SerieA.WebUI.Areas.Admin.Models.MatchModels;
using SerieA.WebUI.Areas.Admin.Models.TeamModels;
using SerieA.WebUI.ViewModels;

namespace SerieA.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MatchController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using HttpClient client = new HttpClient();

            var response = await client.GetAsync("https://localhost:7278/api/admin/matches");
            if (!response.IsSuccessStatusCode)
            {
                return View(new List<MatchListViewModel>());
            }
            var data = await response.Content.ReadFromJsonAsync<List<MatchListViewModel>>();
            return View(data);
        }


        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            using HttpClient client = new HttpClient();

            var response = await client.GetAsync($"https://localhost:7278/api/admin/matches/{id}");
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

            var response = await client.GetAsync($"https://localhost:7278/api/admin/matches/{id}");
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


            var response = await client.PutAsJsonAsync($"https://localhost:7278/api/admin/matches/{updateTeamViewModel.Id}", updateTeamViewModel);

            if (!response.IsSuccessStatusCode)
                return BadRequest("Takım güncellenemedi.");

            return RedirectToAction("Index");
        }

        public IActionResult Create() { return View(); }


        [HttpPost]
        public async Task<IActionResult> Create(CreateTeamViewModel createTeamViewModel)
        {
            if (!ModelState.IsValid)
                return View(createTeamViewModel);

            using HttpClient client = new HttpClient();

            var response = await client.PostAsJsonAsync("https://localhost:7278/api/admin/matches", createTeamViewModel);
            if (!response.IsSuccessStatusCode)
                return BadRequest("Takım eklenemedi.");

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            using HttpClient client = new HttpClient();
            var response = await client.DeleteAsync($"https://localhost:7278/api/admin/matches/{id}");
            if (!response.IsSuccessStatusCode)
                return BadRequest("Takım silinemedi.");

            return RedirectToAction("Index");
        }

    }
}