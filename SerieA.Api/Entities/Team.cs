using SerieA.Api.Entities.Base;

namespace SerieA.Api.Entities
{
    public class Team : BaseEntity
    {

        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public string City { get; set; }
        public string Stadium { get; set; }



        public ICollection<Match> HomeMathces { get; set; }
        public ICollection<Match> AwayMathces { get; set; }

        public ICollection<MatchGoal> Goals { get; set; }
        public ICollection<MatchCard> MatchCards { get; set; }
        public ICollection<Substıtutıon> Substıtutıons { get; set; }
    }
}
