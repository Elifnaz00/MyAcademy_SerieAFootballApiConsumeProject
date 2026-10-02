using SerieA.Api.Entities;
using SerieA.Api.Entities.Enums;

namespace SerieA.Api.DTOs.MatchCardDtos
{
    public class ResultMatchCardDto
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        public int TeamId { get; set; }

       
        public string PlayerName { get; set; }
        public int Minute { get; set; }
        public MatchCardType CardType { get; set; }
    }
}
