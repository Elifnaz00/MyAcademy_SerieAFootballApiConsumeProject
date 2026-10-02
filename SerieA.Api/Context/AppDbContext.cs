using Microsoft.EntityFrameworkCore;
using SerieA.Api.Entities;
using System;
using System.Reflection.Metadata;

namespace SerieA.Api.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>()
                .HasMany(e => e.MatchCards)
                .WithOne(e => e.Team)
                .HasForeignKey(e => e.TeamId)
                .IsRequired();


            modelBuilder.Entity<Team>()
               .HasMany(e => e.Goals)
               .WithOne(e => e.Team)
               .HasForeignKey(e => e.TeamId)
               .IsRequired();


            modelBuilder.Entity<Team>()
              .HasMany(e => e.Substitutions)
              .WithOne(e => e.Team)
              .HasForeignKey(e => e.TeamId)
              .IsRequired();


            modelBuilder.Entity<Team>()
        .HasMany(e => e.HomeMatches)
        .WithOne(e => e.HomeTeam)
        .HasForeignKey(e => e.HomeTeamId)
        .OnDelete(DeleteBehavior.Restrict)
        .IsRequired();

            modelBuilder.Entity<Team>()
                .HasMany(e => e.AwayMatches)
                .WithOne(e => e.AwayTeam)
                .HasForeignKey(e => e.AwayTeamId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder.Entity<Match>()
         .HasMany(e => e.Goals)
         .WithOne(e => e.Match)
         .HasForeignKey(e => e.MatchId)
         .IsRequired();



            modelBuilder.Entity<Match>()
         .HasMany(e => e.MatchCards)
         .WithOne(e => e.Match)
         .HasForeignKey(e => e.MatchId)
         .IsRequired();

            modelBuilder.Entity<Match>()
        .HasMany(e => e.Substitutions)
        .WithOne(e => e.Match)
        .HasForeignKey(e => e.MatchId)
        .IsRequired();


        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<MatchCard> MatchCards { get; set; }
        public DbSet<Substitution> Substitutions { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<MatchGoal> MatchGoals { get; set; }
    }
}
