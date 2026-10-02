using SerieA.Api.DTOs.MatchCardDtos;
using SerieA.Api.DTOs.MatchGoalDtos;
using SerieA.Api.DTOs.SubstitutionDto;
using SerieA.Api.Entities;
using SerieA.Api.Entities.Enums;

namespace SerieA.Api.DTOs.MatchesDtos
{
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


        public List<ResultMatchGoalDto> Goals { get; set; }

        public List<ResultMatchCardDto> MatchCards { get; set; }

        public List<ResultSubstitutionDto> Substitutions { get; set; }


    }
}
