using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SerieA.Api.Context;
using SerieA.Api.DTOs.MatchesDtos;
using SerieA.Api.DTOs.TeamDtos;
using SerieA.Api.Entities;

namespace SerieA.Api.Controllers.Admin
{
    [Route("api/admin/matches")]
    [ApiController]
    public class MatchesController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public MatchesController(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }    

      [HttpGet]
        public async Task<IActionResult> GetMatches()
        {
            var matches = await _appDbContext.Matches.AsNoTracking().Include(x=>x.AwayTeam).Include(x=>x.HomeTeam).ToListAsync();
            var mapped = _mapper.Map<List<MatchDto>>(matches);
            return Ok(mapped);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetTeam(int id)
        {
            var matches = await _appDbContext.Teams.FindAsync(id);
            if (matches is null)
                return NotFound();

            var mapped = _mapper.Map<MatchDto>(matches);
            return Ok(mapped);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTeam(int id, UpdateMatchDto updateMatchDto)
        {
            var team = await _appDbContext.Matches.FindAsync(id);
            if (team is null)
                return NotFound("Takım bulunamadı");

            _mapper.Map(updateMatchDto, team);
            await _appDbContext.SaveChangesAsync();
            return NoContent();
        }


        [HttpPost]
        public async Task<IActionResult> CreateTeam(CreateMatchDto createMatchDto)
        {
            var match = _mapper.Map<Match>(createMatchDto);
            await _appDbContext.Matches.AddAsync(match);
            await _appDbContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetTeam), new { id = match.Id }, match);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeam(int id)
        {
            var team = await _appDbContext.Matches.FindAsync(id);
            if (team is null)
                return NotFound("Takım bulunamadı");

            _appDbContext.Matches.Remove(team);
            await _appDbContext.SaveChangesAsync();
            return NoContent();
        }
    } }
