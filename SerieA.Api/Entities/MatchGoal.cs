using SerieA.Api.Entities.Base;

namespace SerieA.Api.Entities
{
    public class MatchGoal : BaseEntity
    {
        public int MatchId { get; set; }
        public int TeamId { get; set; }

        public Team Team { get; set; }
        public Match Match { get; set; }     
        public string PlayerName { get; set; }
        public int Minute { get; set; }
    }
}
