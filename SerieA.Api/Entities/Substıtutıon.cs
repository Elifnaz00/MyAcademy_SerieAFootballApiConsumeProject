using SerieA.Api.Entities.Base;

namespace SerieA.Api.Entities
{
    public class Substıtutıon : BaseEntity
    {
        public int MatchId { get; set; }
        public int TeamId { get; set; }

        public Team Team { get; set; }
        public Match Match { get; set; }
        public string PlayerIn { get; set; }
        public string PlayerOut{ get; set; }
        public int Minute{ get; set; }
    }
}
