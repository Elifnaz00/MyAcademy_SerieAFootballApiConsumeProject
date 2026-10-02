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
           var matches= await _context.Matches.AsNoTracking().ToListAsync();
           var mappedMatches = _mapper.Map<List<ResultMatchesDto>>(matches);   

            return Ok(mappedMatches);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetMatchDetail(int id)
        {
            var match = await _context.Matches
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

           var mappedMatch = _mapper.Map<MatchDetailDto>(match);

            return Ok(mappedMatch);
        }
    }
}
