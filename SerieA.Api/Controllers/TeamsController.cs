using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SerieA.Api.Context;
using SerieA.Api.DTOs.TeamDtos;
using SerieA.Api.Entities;

namespace SerieA.Api.Controllers
{
    [Route("api/admin/teams")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public TeamsController(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetTeams()
        {
            var teams = await _appDbContext.Teams.AsNoTracking().ToListAsync();
            var mapped = _mapper.Map<List<TeamDto>>(teams);
            return Ok(mapped);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetTeam(int id)
        {
            var teams = await _appDbContext.Teams.FindAsync(id);
            if(teams is null)
                return NotFound();

            var mapped= _mapper.Map<TeamDto>(teams);
            return Ok(mapped);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTeam(int id, UpdateTeamDto updateTeamDto)
        {
            var team = await _appDbContext.Teams.FindAsync(id);
            if (team is null)
                return NotFound("Takım bulunamadı");

            _mapper.Map(updateTeamDto, team);
            await _appDbContext.SaveChangesAsync();
            return NoContent();
        }


        [HttpPost]
        public async Task<IActionResult> CreateTeam(CreateTeamDto createTeamDto)
        {
            var team= _mapper.Map<Team>(createTeamDto);
            await _appDbContext.Teams.AddAsync(team);
            await _appDbContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetTeam),new { id = team.Id }, team);
        }
    }
}
