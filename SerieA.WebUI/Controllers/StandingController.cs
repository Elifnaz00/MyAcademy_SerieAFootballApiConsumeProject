using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace SerieA.WebUI.Controllers
{
    public class StandingController : Controller
    {
        public async Task<IActionResult> Index()
        {
            /*
            var client= new HttpClient();
            var httpResponseMessage= await client.GetAsync("https://localhost:7278/api/standings");
            if(!httpResponseMessage.IsSuccessStatusCode)
            {
                throw new Exception("Error while calling the API");
            }

            var httpContent= await httpResponseMessage.Content.ReadAsStringAsync();
            var data= JsonConvert.DeserializeObject<StandingsResultViewModel>(httpContent);

            return View(data);
            */
            return View();
        }
    }
}
