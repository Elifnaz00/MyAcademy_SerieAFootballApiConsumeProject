using SerieA.Api.Entities.Enums;

namespace SerieA.WebUI.Areas.Admin.Models.MatchModels
{
    public class CreateMatchViewModel
    {
       

        public string Week { get; set; }
        public DateTime MatchDate { get; set; }

        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }

        public int HomeScore { get; set; }
        public int AwayScore { get; set; }

        public MatchStatus Status { get; set; }

        public string Stadium { get; set; }
    }
}
