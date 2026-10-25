using SerieA.Api.Entities.Enums;

namespace SerieA.Api.DTOs.MatchesDtos
{
    public class MatchDto
    {
        public int Id { get; set; }

        public string Week { get; set; }
        public DateTime MatchDate { get; set; }

        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }

        public string HomeName { get; set; }

        public string AwayName { get; set; }

        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public string Stadium { get; set; }

        public MatchStatus Status { get; set; }
    }
}
