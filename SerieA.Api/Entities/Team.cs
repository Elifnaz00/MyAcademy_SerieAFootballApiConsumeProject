using SerieA.Api.Entities.Base;

namespace SerieA.Api.Entities
{
    public class Team : BaseEntity
    {

        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public string City { get; set; }
        public string Stadium { get; set; }



        public ICollection<Match> HomeMatches { get; set; }
        public ICollection<Match> AwayMatches { get; set; }

        public ICollection<MatchGoal> Goals { get; set; }
        public ICollection<MatchCard> MatchCards { get; set; }
        public ICollection<Substitution> Substitutions { get; set; }
    }
}
