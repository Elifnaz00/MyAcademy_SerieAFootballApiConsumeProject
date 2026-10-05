namespace SerieA.WebUI.ViewModels
{
    public class FixturesResultViewModel
    {
        public int Id { get; set; }

        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }

        public TeamViewModel HomeTeam { get; set; }
        public TeamViewModel AwayTeam { get; set; }

        public string Week { get; set; }

        public DateTime MatchDate { get; set; }

        public int HomeScore { get; set; }
        public int AwayScore { get; set; }

        public int Status { get; set; }

        public string Stadium { get; set; }
    }
}
