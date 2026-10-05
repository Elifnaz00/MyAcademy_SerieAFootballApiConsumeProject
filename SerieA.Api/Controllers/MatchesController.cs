using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using SerieA.Api.Context;
using SerieA.Api.DTOs.MatchesDtos;

namespace SerieA.Api.Controllers
{
    [Route("api/matches")]
    [ApiController]
    public class MatchesController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public MatchesController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetMatches()
        {
           var matches= await _context.Matches.AsNoTracking().Include(x => x.HomeTeam)
    .Include(x => x.AwayTeam).ToListAsync();
           var mappedMatches = _mapper.Map<List<ResultMatchesDto>>(matches);   

            return Ok(mappedMatches);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetMatchDetail(int id)
        {
            var match = await _context.Matches
                .AsNoTracking()
                .Include(x => x.HomeTeam)
                .Include(x => x.AwayTeam)
                .Include(x => x.Goals)
                .Include(x => x.MatchCards)
                .Include(x => x.Substitutions)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (match is null)
            {
                return NotFound("Maç bulunamadı.");
            }

            var dto = _mapper.Map<MatchDetailDto>(match);


            // Gol sayıları
            dto.HomeGoalCount = dto.Goals.Count(x =>
                x.TeamId == dto.HomeTeamId);

            dto.AwayGoalCount = dto.Goals.Count(x =>
                x.TeamId == dto.AwayTeamId);


            // İlk yarı skorları
            dto.HomeFirstHalfScore = dto.Goals.Count(x =>
                x.TeamId == dto.HomeTeamId &&
                x.Minute <= 45);

            dto.AwayFirstHalfScore = dto.Goals.Count(x =>
                x.TeamId == dto.AwayTeamId &&
                x.Minute <= 45);


            // İkinci yarı skorları
            dto.HomeSecondHalfScore =
                dto.HomeScore - dto.HomeFirstHalfScore;

            dto.AwaySecondHalfScore =
                dto.AwayScore - dto.AwayFirstHalfScore;

            dto.HomeGoals = dto.Goals
           .Where(x => x.TeamId == dto.HomeTeamId)
           .OrderBy(x => x.Minute)
           .ToList();

            dto.AwayGoals = dto.Goals
                .Where(x => x.TeamId == dto.AwayTeamId)
                .OrderBy(x => x.Minute)
                .ToList();
            return Ok(dto);
        }


        [HttpGet("week/{week}")]    
        public async Task<IActionResult> GetMatchesByWeek(string week)
        {
            var matchesByWeek= await _context.Matches.AsNoTracking().Include(x=>x.AwayTeam).Include(x=>x.HomeTeam).Where(x => x.Week == week).ToListAsync();

            var mappedMatches = _mapper.Map<List<ResultMatchesDto>>(matchesByWeek);
            return Ok(mappedMatches);
        }
    }
}
