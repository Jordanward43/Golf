using System;

namespace golf.Models
{
    public class Player
    {
        public readonly string Name;
        public int PlayerNumbers { get; set; }
        public Player(string name, int playerNumbers)
        { 
            Name = name; 
            PlayerNumbers = playerNumbers;
        }
    }
}