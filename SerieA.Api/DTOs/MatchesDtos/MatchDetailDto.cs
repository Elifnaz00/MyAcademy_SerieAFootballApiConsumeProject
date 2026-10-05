using SerieA.Api.DTOs.MatchCardDtos;
using SerieA.Api.DTOs.MatchGoalDtos;
using SerieA.Api.DTOs.SubstitutionDto;
using SerieA.Api.Entities.Enums;

public class MatchDetailDto
{
    public int HomeTeamId { get; set; }
    public int AwayTeamId { get; set; }

    public string HomeTeamName { get; set; }
    public string AwayTeamName { get; set; }

    public string Week { get; set; }
    public DateTime MatchDate { get; set; }

    public int HomeScore { get; set; }
    public int AwayScore { get; set; }

    public MatchStatus Status { get; set; }
    public string Stadium { get; set; }

    public int HomeGoalCount { get; set; }
    public int AwayGoalCount { get; set; }

    public int HomeFirstHalfScore { get; set; }
    public int AwayFirstHalfScore { get; set; }

    public int HomeSecondHalfScore { get; set; }
    public int AwaySecondHalfScore { get; set; }
    public List<ResultMatchGoalDto> HomeGoals { get; set; }
    public List<ResultMatchGoalDto> AwayGoals { get; set; }

    public List<ResultMatchGoalDto> Goals { get; set; }
    public List<ResultMatchCardDto> MatchCards { get; set; }
    public List<ResultSubstitutionDto> Substitutions { get; set; }
}