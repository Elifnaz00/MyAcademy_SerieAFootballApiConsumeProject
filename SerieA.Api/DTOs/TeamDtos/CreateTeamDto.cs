namespace SerieA.Api.DTOs.TeamDtos
{
    public class CreateTeamDto
    {
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public string City { get; set; }
        public string Stadium { get; set; }
        public string Capacity { get; set; }

        public string Founded { get; set; }

        public bool IsActive { get; set; }
        public string ColorA { get; set; }
        public string ColorB { get; set; }
    }
}
