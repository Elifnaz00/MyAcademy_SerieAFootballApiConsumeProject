using Microsoft.AspNetCore.Mvc;
using SerieA.WebUI.ViewModels;
using System.Text.Json;

namespace SerieA.WebUI.Controllers
{
    public class FixturesController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using HttpClient client = new HttpClient();

            var response = await client.GetAsync(
                "https://localhost:7278/api/matches/week/1");

            if (!response.IsSuccessStatusCode)
            {
                return View(new List<FixturesResultViewModel>());
            }

            var data = await response.Content.ReadFromJsonAsync<List<FixturesResultViewModel>>();

            return View(data);


        }

        [HttpGet]
        public async Task<IActionResult> GetByWeek(string week)
        {
            using var client = new HttpClient();

            var response = await client.GetAsync(
                $"https://localhost:7278/api/matches/week/{week}");

            if (!response.IsSuccessStatusCode)
            {
                return StatusCode((int)response.StatusCode);
            }

            var json = await response.Content.ReadAsStringAsync();

            var matches = JsonSerializer.Deserialize<List<FixturesResultViewModel>>(
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            return Json(matches);
        }



        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            using var client = new HttpClient();

            var response = await client.GetAsync(
                $"https://localhost:7278/api/matches/{id}");

            if (!response.IsSuccessStatusCode)
            {
                return StatusCode((int)response.StatusCode);
            }

            var json = await response.Content.ReadAsStringAsync();

            var match = JsonSerializer.Deserialize<MatchDetailViewModel>(
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            if (match == null)
            {
                return NotFound();
            }

            return View(match);
        }
    }
    }
