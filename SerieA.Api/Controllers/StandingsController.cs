using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SerieA.Api.Context;
using SerieA.Api.Entities.Enums;

namespace SerieA.Api.Controllers
{
    [Route("api/standings")]
    [ApiController]
    public class StandingsController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public StandingsController(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetStandings()
        {
            var finishedMatches= await _appDbContext.Matches.AsNoTracking().Include(x=> x.AwayTeam).Include(x=>x.HomeTeam).Where(a=>a.Status == MatchStatus.Finished).ToListAsync();
            return Ok();
        }
    }
}
