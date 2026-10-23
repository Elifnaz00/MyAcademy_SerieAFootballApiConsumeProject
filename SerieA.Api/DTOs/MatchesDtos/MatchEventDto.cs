namespace SerieA.Api.DTOs.MatchesDtos
{
    public class MatchEventDto
    {
        public int Minute { get; set; }
        public string EventType { get; set; }
        public string PlayerName { get; set; }
        public int TeamId { get; set; }
    }
}
