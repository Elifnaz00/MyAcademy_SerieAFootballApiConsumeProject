using SerieA.Api.Entities;
using SerieA.Api.Entities.Enums;

namespace SerieA.Api.DTOs.MatchesDtos
{
    public class ResultMatchesDto
    {
     public int Id { get; set; }
    public int HomeTeamId { get; set; }
    public int AwayTeamId { get; set; }

    public Team HomeTeam { get; set; }
    public Team AwayTeam { get; set; }

    public string Week { get; set; }
    public DateTime MatchDate { get; set; }

    public int HomeScore { get; set; }
    public int AwayScore { get; set; }
    public MatchStatus Status { get; set; }
    public string Stadium { get; set; }

}
}
