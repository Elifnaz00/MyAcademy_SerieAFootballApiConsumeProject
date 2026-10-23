using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SerieA.Api.Context;

namespace SerieA.Api.Controllers
{
    [Route("api/admin/[controller]")]
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
            return Ok(teams);
        }


        [HttpGet("id")]
        public async Task<IActionResult> GetTeam(int id)
        {
            var teams = await _appDbContext.Teams.FindAsync(id);
            if(teams is null)
                return NotFound();

            return Ok(teams);
        }
    }
}
