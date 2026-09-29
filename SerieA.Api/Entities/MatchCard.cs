using SerieA.Api.Entities.Base;
using SerieA.Api.Entities.Enums;

namespace SerieA.Api.Entities
{
    public class MatchCard : BaseEntity
    {
        public int MatchId { get; set; }
        public int TeamId { get; set; }

        public Team Team { get; set; }
        public Match Match { get; set; }
        public string PlayerName { get; set; }
        public int Minute { get; set; }
        public MatchCardType CardType { get; set; }
    }
}
