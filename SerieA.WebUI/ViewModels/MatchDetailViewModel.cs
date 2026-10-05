using System;
using System.Collections.Generic;

namespace SerieA.WebUI.ViewModels
{
    public class MatchDetailViewModel
    {
        // Maç bilgileri
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }

        public string HomeTeamName { get; set; }
        public string AwayTeamName { get; set; }

        public string Week { get; set; }
        public DateTime MatchDate { get; set; }

        public int HomeScore { get; set; }
        public int AwayScore { get; set; }

        public int Status { get; set; }

        public string Stadium { get; set; }


        // API tarafından hesaplanan bilgiler
        public int HomeGoalCount { get; set; }
        public int AwayGoalCount { get; set; }

        public int HomeFirstHalfScore { get; set; }
        public int AwayFirstHalfScore { get; set; }

        public int HomeSecondHalfScore { get; set; }
        public int AwaySecondHalfScore { get; set; }
        public List<GoalViewModel> HomeGoals { get; set; } = new();

        public List<GoalViewModel> AwayGoals { get; set; } = new();

        // Maç detayları
        public List<GoalViewModel> Goals { get; set; } = new();

        public List<MatchCardViewModel> MatchCards { get; set; } = new();

        public List<SubstitutionViewModel> Substitutions { get; set; } = new();
    }


}