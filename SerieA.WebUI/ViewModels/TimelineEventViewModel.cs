namespace SerieA.WebUI.ViewModels
{
    public class TimelineEventViewModel
    {
        public string Type { get; set; }

        public int TeamId { get; set; }

        public int Minute { get; set; }

        public string PlayerName { get; set; }

        public string PlayerIn { get; set; }

        public string PlayerOut { get; set; }

        public int CardType { get; set; }
    }
}
