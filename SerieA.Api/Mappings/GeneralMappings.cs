using AutoMapper;
using SerieA.Api.DTOs.MatchCardDtos;
using SerieA.Api.DTOs.MatchesDtos;
using SerieA.Api.DTOs.MatchGoalDtos;
using SerieA.Api.DTOs.SubstitutionDto;
using SerieA.Api.DTOs.TeamDtos;
using SerieA.Api.Entities;

namespace SerieA.Api.Mappings
{
    public class GeneralMappings : Profile
    {
        public GeneralMappings()
        {
           

            CreateMap<Match, ResultMatchesDto>();
            CreateMap<Match, MatchDetailDto>()
            .ForMember(dest => dest.HomeTeamName,
                opt => opt.MapFrom(src => src.HomeTeam.Name))
            .ForMember(dest => dest.AwayTeamName,
                opt => opt.MapFrom(src => src.AwayTeam.Name));

            CreateMap<MatchCard, ResultMatchCardDto>();
            CreateMap<Substitution, ResultSubstitutionDto>();
            CreateMap<MatchGoal, ResultMatchGoalDto>();
            CreateMap<Team, TeamDto>();
          
        }
    }
}

