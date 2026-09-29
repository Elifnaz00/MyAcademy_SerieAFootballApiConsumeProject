using SerieA.Api.Entities.Base;
using SerieA.Api.Entities.Enums;
using System.Collections.ObjectModel;

namespace SerieA.Api.Entities
{
    public class Match : BaseEntity
    {
      
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }

        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }

        public string Week { get; set; }
        public DateTime MatchDate { get; set; }
      
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public MatchStatus Status { get; set; }
        public string Stadium { get; set; }


        public ICollection<MatchGoal> Goals { get; set; }
        public ICollection<MatchCard> MatchCards { get; set; }
        public ICollection<Substıtutıon> Substıtutıons { get; set; }


    }
}
