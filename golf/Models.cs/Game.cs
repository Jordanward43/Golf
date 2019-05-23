using System;

namespace golf.Models
{
    public class Game
    {
        public readonly string HoleNumber;
        public int HolePar;
        public readonly string Player;
        public Game (string holeNumber, int holePar, string player)
        {
            HoleNumber = holeNumber;
            HolePar = holePar;
            Player = player;
        }
    }
}