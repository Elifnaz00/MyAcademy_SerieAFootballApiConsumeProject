namespace SerieA.WebUI.ViewModels
{
    public class GoalViewModel
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        public int TeamId { get; set; }

        public string PlayerName { get; set; }
        public int Minute { get; set; }
    }
}
