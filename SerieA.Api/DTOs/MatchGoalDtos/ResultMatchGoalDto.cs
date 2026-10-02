using SerieA.Api.Entities;

namespace SerieA.Api.DTOs.MatchGoalDtos
{
    public class ResultMatchGoalDto
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        public int TeamId { get; set; }

       
        public string PlayerName { get; set; }
        public int Minute { get; set; }
    }

}
