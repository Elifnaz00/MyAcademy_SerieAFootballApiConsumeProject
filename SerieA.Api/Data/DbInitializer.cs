using SerieA.Api.Context;
using SerieA.Api.Entities;
using SerieA.Api.Entities.Enums;

namespace SerieA.Api.Data
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            
            if (context.Teams.Any())
                return;




            var teams = new List<Team>
{
    new Team
    {
        Name = "Inter",
        LogoUrl = "/images/teams/inter.jpg",
        City = "Milano",
        Stadium = "San Siro",
        Capacity = "75.817",
        Founded = "1908",
        IsActive = true,
        ColorA = "#0A4FA8",
        ColorB = "#101418"
    },
    new Team
    {
        Name = "Milan",
        LogoUrl = "/images/teams/milan.png",
        City = "Milano",
        Stadium = "San Siro",
        Capacity = "75.817",
        Founded = "1899",
        IsActive = true,
        ColorA = "#FB090B",
        ColorB = "#000000"
    },
    new Team
    {
        Name = "Juventus",
        LogoUrl = "/images/teams/juventus.png",
        City = "Torino",
        Stadium = "Allianz Stadium",
        Capacity = "41.507",
        Founded = "1897",
        IsActive = true,
        ColorA = "#000000",
        ColorB = "#FFFFFF"
    },
    new Team
    {
        Name = "Napoli",
        LogoUrl = "/images/teams/napoli.png",
        City = "Napoli",
        Stadium = "Stadio Diego Armando Maradona",
        Capacity = "54.726",
        Founded = "1926",
        IsActive = true,
        ColorA = "#12A0D7",
        ColorB = "#FFFFFF"
    },
    new Team
    {
        Name = "Roma",
        LogoUrl = "/images/teams/roma.png",
        City = "Roma",
        Stadium = "Stadio Olimpico",
        Capacity = "70.634",
        Founded = "1927",
        IsActive = true,
        ColorA = "#8E1F2F",
        ColorB = "#F0BC42"
    },
    new Team
    {
        Name = "Lazio",
        LogoUrl = "/images/teams/lazio.jpg",
        City = "Roma",
        Stadium = "Stadio Olimpico",
        Capacity = "70.634",
        Founded = "1900",
        IsActive = true,
        ColorA = "#87D8F7",
        ColorB = "#FFFFFF"
    },
    new Team
    {
        Name = "Atalanta",
        LogoUrl = "/images/teams/atalanta.png",
        City = "Bergamo",
        Stadium = "Gewiss Stadium",
        Capacity = "24.950",
        Founded = "1907",
        IsActive = true,
        ColorA = "#0055A4",
        ColorB = "#000000"
    },
    new Team
    {
        Name = "Fiorentina",
        LogoUrl = "/images/teams/fiorentina.png",
        City = "Firenze",
        Stadium = "Stadio Artemio Franchi",
        Capacity = "43.147",
        Founded = "1926",
        IsActive = true,
        ColorA = "#482E92",
        ColorB = "#FFFFFF"
    },
    new Team
    {
        Name = "Bologna",
        LogoUrl = "/images/teams/bologna.png",
        City = "Bologna",
        Stadium = "Stadio Renato Dall'Ara",
        Capacity = "38.279",
        Founded = "1909",
        IsActive = true,
        ColorA = "#CF102D",
        ColorB = "#1B3A6B"
    },
    new Team
    {
        Name = "Torino",
        LogoUrl = "/images/teams/torino.png",
        City = "Torino",
        Stadium = "Stadio Olimpico Grande Torino",
        Capacity = "27.958",
        Founded = "1906",
        IsActive = true,
        ColorA = "#8B1E2D",
        ColorB = "#FFFFFF"
    },
    new Team
    {
        Name = "Genoa",
        LogoUrl = "/images/teams/genoa.png",
        City = "Genova",
        Stadium = "Stadio Luigi Ferraris",
        Capacity = "36.599",
        Founded = "1893",
        IsActive = true,
        ColorA = "#B51F2A",
        ColorB = "#1B3A6B"
    },
    new Team
    {
        Name = "Sampdoria",
        LogoUrl = "/images/teams/sampdoria.png",
        City = "Genova",
        Stadium = "Stadio Luigi Ferraris",
        Capacity = "36.599",
        Founded = "1946",
        IsActive = true,
        ColorA = "#0066B3",
        ColorB = "#FFFFFF"
    },
    new Team
    {
        Name = "Udinese",
        LogoUrl = "/images/teams/udinese.png",
        City = "Udine",
        Stadium = "Bluenergy Stadium",
        Capacity = "25.144",
        Founded = "1896",
        IsActive = true,
        ColorA = "#000000",
        ColorB = "#FFFFFF"
    },
    new Team
    {
        Name = "Cagliari",
        LogoUrl = "/images/teams/cagliari.jpg",
        City = "Cagliari",
        Stadium = "Unipol Domus",
        Capacity = "16.416",
        Founded = "1920",
        IsActive = true,
        ColorA = "#C8102E",
        ColorB = "#00529F"
    },
    new Team
    {
        Name = "Sassuolo",
        LogoUrl = "/images/teams/sassuolo.png",
        City = "Sassuolo",
        Stadium = "Mapei Stadium",
        Capacity = "21.525",
        Founded = "1920",
        IsActive = true,
        ColorA = "#008751",
        ColorB = "#000000"
    },
    new Team
    {
        Name = "Parma",
        LogoUrl = "/images/teams/parma.png",
        City = "Parma",
        Stadium = "Stadio Ennio Tardini",
        Capacity = "22.352",
        Founded = "1913",
        IsActive = true,
        ColorA = "#FFD700",
        ColorB = "#00529F"
    },
    new Team
    {
        Name = "Lecce",
        LogoUrl = "/images/teams/lecce.png",
        City = "Lecce",
        Stadium = "Stadio Via del Mare",
        Capacity = "31.445",
        Founded = "1908",
        IsActive = true,
        ColorA = "#F7D117",
        ColorB = "#D71920"
    },
    new Team
    {
        Name = "Verona",
        LogoUrl = "/images/teams/verona.png",
        City = "Verona",
        Stadium = "Stadio Marcantonio Bentegodi",
        Capacity = "31.713",
        Founded = "1903",
        IsActive = true,
        ColorA = "#0057A8",
        ColorB = "#F7D117"
    },
    new Team
    {
        Name = "Empoli",
        LogoUrl = "/images/teams/empoli.png",
        City = "Empoli",
        Stadium = "Stadio Carlo Castellani",
        Capacity = "16.167",
        Founded = "1920",
        IsActive = true,
        ColorA = "#005CA9",
        ColorB = "#FFFFFF"
    },
    new Team
    {
        Name = "Monza",
        LogoUrl = "/images/teams/monza.jpg",
        City = "Monza",
        Stadium = "U-Power Stadium",
        Capacity = "17.102",
        Founded = "1912",
        IsActive = true,
        ColorA = "#E30613",
        ColorB = "#FFFFFF"
    }
};


            context.Teams.AddRange(teams);
            context.SaveChanges();


            // =========================
            // 2. MATCHES
            // =========================

            var matches = new List<Match>
            {
                // =========================
                // WEEK 1
                // =========================

                new Match
                {
                    HomeTeamId = teams[0].Id,
                    AwayTeamId = teams[16].Id,
                    Week = "1",
                    MatchDate = new DateTime(2026, 8, 22, 20, 45, 0),
                    HomeScore = 3,
                    AwayScore = 0,
                    Status = MatchStatus.Finished,
                    Stadium = "San Siro"
                },

                new Match
                {
                    HomeTeamId = teams[1].Id,
                    AwayTeamId = teams[18].Id,
                    Week = "1",
                    MatchDate = new DateTime(2026, 8, 22, 18, 00, 0),
                    HomeScore = 2,
                    AwayScore = 1,
                    Status = MatchStatus.Finished,
                    Stadium = "San Siro"
                },

                new Match
                {
                    HomeTeamId = teams[2].Id,
                    AwayTeamId = teams[17].Id,
                    Week = "1",
                    MatchDate = new DateTime(2026, 8, 23, 20, 45, 0),
                    HomeScore = 2,
                    AwayScore = 0,
                    Status = MatchStatus.Finished,
                    Stadium = "Allianz Stadium"
                },

                new Match
                {
                    HomeTeamId = teams[3].Id,
                    AwayTeamId = teams[19].Id,
                    Week = "1",
                    MatchDate = new DateTime(2026, 8, 23, 18, 00, 0),
                    HomeScore = 3,
                    AwayScore = 1,
                    Status = MatchStatus.Finished,
                    Stadium = "Stadio Diego Armando Maradona"
                },

                new Match
                {
                    HomeTeamId = teams[4].Id,
                    AwayTeamId = teams[15].Id,
                    Week = "1",
                    MatchDate = new DateTime(2026, 8, 23, 20, 45, 0),
                    HomeScore = 2,
                    AwayScore = 2,
                    Status = MatchStatus.Finished,
                    Stadium = "Stadio Olimpico"
                },

                new Match
                {
                    HomeTeamId = teams[5].Id,
                    AwayTeamId = teams[13].Id,
                    Week = "1",
                    MatchDate = new DateTime(2026, 8, 24, 20, 45, 0),
                    HomeScore = 1,
                    AwayScore = 0,
                    Status = MatchStatus.Finished,
                    Stadium = "Stadio Olimpico"
                },

                new Match
                {
                    HomeTeamId = teams[6].Id,
                    AwayTeamId = teams[12].Id,
                    Week = "1",
                    MatchDate = new DateTime(2026, 8, 24, 18, 00, 0),
                    HomeScore = 2,
                    AwayScore = 1,
                    Status = MatchStatus.Finished,
                    Stadium = "Gewiss Stadium"
                },

                new Match
                {
                    HomeTeamId = teams[7].Id,
                    AwayTeamId = teams[10].Id,
                    Week = "1",
                    MatchDate = new DateTime(2026, 8, 24, 20, 45, 0),
                    HomeScore = 1,
                    AwayScore = 1,
                    Status = MatchStatus.Finished,
                    Stadium = "Stadio Artemio Franchi"
                },

                new Match
                {
                    HomeTeamId = teams[8].Id,
                    AwayTeamId = teams[14].Id,
                    Week = "1",
                    MatchDate = new DateTime(2026, 8, 25, 18, 00, 0),
                    HomeScore = 2,
                    AwayScore = 0,
                    Status = MatchStatus.Finished,
                    Stadium = "Stadio Renato Dall'Ara"
                },

                new Match
                {
                    HomeTeamId = teams[9].Id,
                    AwayTeamId = teams[11].Id,
                    Week = "1",
                    MatchDate = new DateTime(2026, 8, 25, 20, 45, 0),
                    HomeScore = 1,
                    AwayScore = 0,
                    Status = MatchStatus.Finished,
                    Stadium = "Stadio Olimpico Grande Torino"
                },


                // =========================
                // WEEK 2
                // =========================

                new Match
                {
                    HomeTeamId = teams[1].Id,
                    AwayTeamId = teams[16].Id,
                    Week = "2",
                    MatchDate = new DateTime(2026, 8, 29, 18, 00, 0),
                    HomeScore = 3,
                    AwayScore = 0,
                    Status = MatchStatus.Finished,
                    Stadium = "San Siro"
                },

                new Match
                {
                    HomeTeamId = teams[0].Id,
                    AwayTeamId = teams[17].Id,
                    Week = "2",
                    MatchDate = new DateTime(2026, 8, 29, 20, 45, 0),
                    HomeScore = 2,
                    AwayScore = 1,
                    Status = MatchStatus.Finished,
                    Stadium = "San Siro"
                },

                new Match
                {
                    HomeTeamId = teams[2].Id,
                    AwayTeamId = teams[18].Id,
                    Week = "2",
                    MatchDate = new DateTime(2026, 8, 30, 20, 45, 0),
                    HomeScore = 3,
                    AwayScore = 0,
                    Status = MatchStatus.Finished,
                    Stadium = "Allianz Stadium"
                },

                new Match
                {
                    HomeTeamId = teams[3].Id,
                    AwayTeamId = teams[15].Id,
                    Week = "2",
                    MatchDate = new DateTime(2026, 8, 30, 18, 00, 0),
                    HomeScore = 2,
                    AwayScore = 0,
                    Status = MatchStatus.Finished,
                    Stadium = "Stadio Diego Armando Maradona"
                },

                new Match
                {
                    HomeTeamId = teams[4].Id,
                    AwayTeamId = teams[19].Id,
                    Week = "2",
                    MatchDate = new DateTime(2026, 8, 30, 20, 45, 0),
                    HomeScore = 1,
                    AwayScore = 1,
                    Status = MatchStatus.Finished,
                    Stadium = "Stadio Olimpico"
                },

                new Match
                {
                    HomeTeamId = teams[5].Id,
                    AwayTeamId = teams[12].Id,
                    Week = "2",
                    MatchDate = new DateTime(2026, 8, 31, 18, 00, 0),
                    HomeScore = 2,
                    AwayScore = 1,
                    Status = MatchStatus.Finished,
                    Stadium = "Stadio Olimpico"
                },

                new Match
                {
                    HomeTeamId = teams[6].Id,
                    AwayTeamId = teams[13].Id,
                    Week = "2",
                    MatchDate = new DateTime(2026, 8, 31, 20, 45, 0),
                    HomeScore = 3,
                    AwayScore = 1,
                    Status = MatchStatus.Finished,
                    Stadium = "Gewiss Stadium"
                },

                new Match
                {
                    HomeTeamId = teams[7].Id,
                    AwayTeamId = teams[14].Id,
                    Week = "2",
                    MatchDate = new DateTime(2026, 8, 31, 18, 00, 0),
                    HomeScore = 2,
                    AwayScore = 2,
                    Status = MatchStatus.Finished,
                    Stadium = "Stadio Artemio Franchi"
                },

                new Match
                {
                    HomeTeamId = teams[8].Id,
                    AwayTeamId = teams[11].Id,
                    Week = "2",
                    MatchDate = new DateTime(2026, 9, 1, 18, 00, 0),
                    HomeScore = 1,
                    AwayScore = 0,
                    Status = MatchStatus.Finished,
                    Stadium = "Stadio Renato Dall'Ara"
                },

                new Match
                {
                    HomeTeamId = teams[9].Id,
                    AwayTeamId = teams[10].Id,
                    Week = "2",
                    MatchDate = new DateTime(2026, 9, 1, 20, 45, 0),
                    HomeScore = 2,
                    AwayScore = 1,
                    Status = MatchStatus.Finished,
                    Stadium = "Stadio Olimpico Grande Torino"
                },


                // =========================
                // WEEK 3
                // =========================

                new Match
                {
                    HomeTeamId = teams[0].Id,
                    AwayTeamId = teams[18].Id,
                    Week = "3",
                    MatchDate = new DateTime(2026, 9, 5, 20, 45, 0),
                    HomeScore = 4,
                    AwayScore = 1,
                    Status = MatchStatus.Finished,
                    Stadium = "San Siro"
                },

                new Match
                {
                    HomeTeamId = teams[1].Id,
                    AwayTeamId = teams[17].Id,
                    Week = "3",
                    MatchDate = new DateTime(2026, 9, 5, 18, 00, 0),
                    HomeScore = 2,
                    AwayScore = 0,
                    Status = MatchStatus.Finished,
                    Stadium = "San Siro"
                },

                new Match
                {
                    HomeTeamId = teams[2].Id,
                    AwayTeamId = teams[16].Id,
                    Week = "3",
                    MatchDate = new DateTime(2026, 9, 6, 20, 45, 0),
                    HomeScore = 2,
                    AwayScore = 0,
                    Status = MatchStatus.Finished,
                    Stadium = "Allianz Stadium"
                },

                new Match
                {
                    HomeTeamId = teams[3].Id,
                    AwayTeamId = teams[19].Id,
                    Week = "3",
                    MatchDate = new DateTime(2026, 9, 6, 18, 00, 0),
                    HomeScore = 1,
                    AwayScore = 1,
                    Status = MatchStatus.Finished,
                    Stadium = "Stadio Diego Armando Maradona"
                },

                new Match
                {
                    HomeTeamId = teams[4].Id,
                    AwayTeamId = teams[12].Id,
                    Week = "3",
                    MatchDate = new DateTime(2026, 9, 6, 20, 45, 0),
                    HomeScore = 3,
                    AwayScore = 1,
                    Status = MatchStatus.Finished,
                    Stadium = "Stadio Olimpico"
                },

                new Match
                {
                    HomeTeamId = teams[5].Id,
                    AwayTeamId = teams[15].Id,
                    Week = "3",
                    MatchDate = new DateTime(2026, 9, 7, 18, 00, 0),
                    HomeScore = 2,
                    AwayScore = 0,
                    Status = MatchStatus.Finished,
                    Stadium = "Stadio Olimpico"
                },

                new Match
                {
                    HomeTeamId = teams[6].Id,
                    AwayTeamId = teams[10].Id,
                    Week = "3",
                    MatchDate = new DateTime(2026, 9, 7, 20, 45, 0),
                    HomeScore = 2,
                    AwayScore = 2,
                    Status = MatchStatus.Finished,
                    Stadium = "Gewiss Stadium"
                },

                new Match
                {
                    HomeTeamId = teams[7].Id,
                    AwayTeamId = teams[13].Id,
                    Week = "3",
                    MatchDate = new DateTime(2026, 9, 7, 18, 00, 0),
                    HomeScore = 3,
                    AwayScore = 0,
                    Status = MatchStatus.Finished,
                    Stadium = "Stadio Artemio Franchi"
                },

                new Match
                {
                    HomeTeamId = teams[8].Id,
                    AwayTeamId = teams[9].Id,
                    Week = "3",
                    MatchDate = new DateTime(2026, 9, 8, 18, 00, 0),
                    HomeScore = 1,
                    AwayScore = 1,
                    Status = MatchStatus.Finished,
                    Stadium = "Stadio Renato Dall'Ara"
                },

                new Match
                {
                    HomeTeamId = teams[14].Id,
                    AwayTeamId = teams[11].Id,
                    Week = "3",
                    MatchDate = new DateTime(2026, 9, 8, 20, 45, 0),
                    HomeScore = 2,
                    AwayScore = 1,
                    Status = MatchStatus.Finished,
                    Stadium = "Mapei Stadium"
                }
            };

            context.Matches.AddRange(matches);
            context.SaveChanges();


            // =========================
            // 3. MATCH GOALS
            // 3 DETAYLI MAÇ
            // =========================

            var goals = new List<MatchGoal>
            {
                // Inter - Lecce
                new MatchGoal
                {
                    MatchId = matches[0].Id,
                    TeamId = teams[0].Id,
                    PlayerName = "Lautaro Martinez",
                    Minute = 18
                },
                new MatchGoal
                {
                    MatchId = matches[0].Id,
                    TeamId = teams[0].Id,
                    PlayerName = "Marcus Thuram",
                    Minute = 47
                },
                new MatchGoal
                {
                    MatchId = matches[0].Id,
                    TeamId = teams[0].Id,
                    PlayerName = "Nicolo Barella",
                    Minute = 76
                },

                // Milan - Empoli
                new MatchGoal
                {
                    MatchId = matches[1].Id,
                    TeamId = teams[1].Id,
                    PlayerName = "Rafael Leao",
                    Minute = 22
                },
                new MatchGoal
                {
                    MatchId = matches[1].Id,
                    TeamId = teams[18].Id,
                    PlayerName = "Lorenzo Colombo",
                    Minute = 51
                },
                new MatchGoal
                {
                    MatchId = matches[1].Id,
                    TeamId = teams[1].Id,
                    PlayerName = "Christian Pulisic",
                    Minute = 83
                },

                // Juventus - Verona
                new MatchGoal
                {
                    MatchId = matches[2].Id,
                    TeamId = teams[2].Id,
                    PlayerName = "Dusan Vlahovic",
                    Minute = 31
                },
                new MatchGoal
                {
                    MatchId = matches[2].Id,
                    TeamId = teams[2].Id,
                    PlayerName = "Federico Chiesa",
                    Minute = 67
                }
            };

            context.MatchGoals.AddRange(goals);


            // =========================
            // 4. MATCH CARDS
            // =========================

            var cards = new List<MatchCard>
            {
                // Inter - Lecce
                new MatchCard
                {
                    MatchId = matches[0].Id,
                    TeamId = teams[16].Id,
                    PlayerName = "Lameck Banda",
                    Minute = 34,
                    CardType = MatchCardType.Yellow
                },
                new MatchCard
                {
                    MatchId = matches[0].Id,
                    TeamId = teams[0].Id,
                    PlayerName = "Hakan Calhanoglu",
                    Minute = 52,
                    CardType = MatchCardType.Yellow
                },
                new MatchCard
                {
                    MatchId = matches[0].Id,
                    TeamId = teams[16].Id,
                    PlayerName = "Federico Baschirotto",
                    Minute = 68,
                    CardType = MatchCardType.Yellow
                },

                // Milan - Empoli
                new MatchCard
                {
                    MatchId = matches[1].Id,
                    TeamId = teams[1].Id,
                    PlayerName = "Fikayo Tomori",
                    Minute = 39,
                    CardType = MatchCardType.Yellow
                },
                new MatchCard
                {
                    MatchId = matches[1].Id,
                    TeamId = teams[18].Id,
                    PlayerName = "Alberto Grassi",
                    Minute = 61,
                    CardType = MatchCardType.Yellow
                },

                // Juventus - Verona
                new MatchCard
                {
                    MatchId = matches[2].Id,
                    TeamId = teams[2].Id,
                    PlayerName = "Manuel Locatelli",
                    Minute = 44,
                    CardType = MatchCardType.Yellow
                },
                new MatchCard
                {
                    MatchId = matches[2].Id,
                    TeamId = teams[17].Id,
                    PlayerName = "Ondrej Duda",
                    Minute = 57,
                    CardType = MatchCardType.Yellow
                }
            };

            context.MatchCards.AddRange(cards);


            // =========================
            // 5. SUBSTITUTIONS
            // =========================

            var substitutions = new List<Substitution>
            {
                // Inter - Lecce
                new Substitution
                {
                    MatchId = matches[0].Id,
                    TeamId = teams[0].Id,
                    PlayerIn = "Davide Frattesi",
                    PlayerOut = "Henrikh Mkhitaryan",
                    Minute = 65
                },
                new Substitution
                {
                    MatchId = matches[0].Id,
                    TeamId = teams[0].Id,
                    PlayerIn = "Marko Arnautovic",
                    PlayerOut = "Marcus Thuram",
                    Minute = 72
                },
                new Substitution
                {
                    MatchId = matches[0].Id,
                    TeamId = teams[16].Id,
                    PlayerIn = "Nikola Krstovic",
                    PlayerOut = "Lameck Banda",
                    Minute = 70
                },

                // Milan - Empoli
                new Substitution
                {
                    MatchId = matches[1].Id,
                    TeamId = teams[1].Id,
                    PlayerIn = "Ruben Loftus-Cheek",
                    PlayerOut = "Tijjani Reijnders",
                    Minute = 64
                },
                new Substitution
                {
                    MatchId = matches[1].Id,
                    TeamId = teams[1].Id,
                    PlayerIn = "Samuel Chukwueze",
                    PlayerOut = "Rafael Leao",
                    Minute = 75
                },
                new Substitution
                {
                    MatchId = matches[1].Id,
                    TeamId = teams[18].Id,
                    PlayerIn = "Sebastiano Esposito",
                    PlayerOut = "Lorenzo Colombo",
                    Minute = 70
                },

                // Juventus - Verona
                new Substitution
                {
                    MatchId = matches[2].Id,
                    TeamId = teams[2].Id,
                    PlayerIn = "Kenan Yildiz",
                    PlayerOut = "Federico Chiesa",
                    Minute = 72
                },
                new Substitution
                {
                    MatchId = matches[2].Id,
                    TeamId = teams[2].Id,
                    PlayerIn = "Teun Koopmeiners",
                    PlayerOut = "Manuel Locatelli",
                    Minute = 76
                },
                new Substitution
                {
                    MatchId = matches[2].Id,
                    TeamId = teams[17].Id,
                    PlayerIn = "Tomas Suslov",
                    PlayerOut = "Darko Lazovic",
                    Minute = 65
                }
            };

            context.Substitutions.AddRange(substitutions);

            context.SaveChanges();
        }
    }
}