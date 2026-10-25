using Microsoft.AspNetCore.Mvc;
using SerieA.Api.Entities.Enums;
using SerieA.WebUI.Areas.Admin.Models.MatchModels;
using SerieA.WebUI.ViewModels;

namespace SerieA.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MatchController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using HttpClient client = new HttpClient();

            var teamsResponse = await client.GetAsync(
                "https://localhost:7278/api/admin/teams");

            if (!teamsResponse.IsSuccessStatusCode)
            {
                ViewBag.Teams = new List<TeamViewModel>();
               
            }
            var teams = await teamsResponse.Content
                      .ReadFromJsonAsync<List<TeamViewModel>>();

            ViewBag.Teams = teams ?? new List<TeamViewModel>();


            var response = await client.GetAsync(
                "https://localhost:7278/api/admin/matches");

            if (!response.IsSuccessStatusCode)
            {
                return View(new List<MatchListViewModel>());
            }

            var data = await response.Content
                .ReadFromJsonAsync<List<MatchListViewModel>>();

            return View(data ?? new List<MatchListViewModel>());
        }


        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            using HttpClient client = new HttpClient();

            var response = await client.GetAsync($"https://localhost:7278/api/admin/matches/{id}");
            if (!response.IsSuccessStatusCode)
            {
                return View(new MatchViewModel());
            }
            var data = await response.Content.ReadFromJsonAsync<MatchViewModel>();
            return View(data);
        }


        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            using HttpClient client = new HttpClient();

            var response = await client.GetAsync($"https://localhost:7278/api/admin/matches/{id}");
            if (!response.IsSuccessStatusCode)
            {
                return View(new UpdateMatchViewModel());
            }
            var data = await response.Content.ReadFromJsonAsync<UpdateMatchViewModel>();
            if (data is null)
                return NotFound();

            return View(data);
        }


        [HttpPost]
        public async Task<IActionResult> Update(UpdateMatchViewModel updateMatchViewModel)
        {
            if (!ModelState.IsValid)
                return View(updateMatchViewModel);


            using HttpClient client = new HttpClient();


            var response = await client.PutAsJsonAsync($"https://localhost:7278/api/admin/matches/{updateMatchViewModel.Id}", updateMatchViewModel);

            if (!response.IsSuccessStatusCode)
                return BadRequest("Maç güncellenemedi.");

            return RedirectToAction("Index");
        }

      

        [HttpPost]
        public async Task<IActionResult> Create(CreateMatchViewModel createMatchViewModel)
        {
            if (!ModelState.IsValid)
                ViewBag.ErrorMessage = "Lütfen girdiğiniz bilgileri kontrol edin.";

            using HttpClient client = new HttpClient();

            var response = await client.PostAsJsonAsync("https://localhost:7278/api/admin/matches", createMatchViewModel);
            if (!response.IsSuccessStatusCode)
                return BadRequest("Maç eklenemedi.");

            return RedirectToAction("Index");
        }


        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            using HttpClient client = new HttpClient();
            var response = await client.DeleteAsync($"https://localhost:7278/api/admin/matches/{id}");
            if (!response.IsSuccessStatusCode)
                return BadRequest("Maç silinemedi.");

            return RedirectToAction("Index");
        }

    }
}