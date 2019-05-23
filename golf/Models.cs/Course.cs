using System;

namespace golf.Models
{
    public class Course
    {
        public readonly string Name;
        public readonly string Players;
        public int TotalScore { get; set; }
        public int NumberOfGames { get; set; }
        public Course (string name, string players, int totalScore, int numberOfGames)
        {
            Name = name;
            Players = players;
            TotalScore = totalScore;
            NumberOfGames = numberOfGames;
        }
    }
}