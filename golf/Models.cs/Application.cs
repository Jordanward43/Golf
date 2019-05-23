using System;

namespace golf.Models
{
    public class Application
    {
        private void Greeting()
        {
            System.Console.WriteLine("Good luck with your golf game. Use me to help keep track of scores and players.");
        }
        private void PlayerInfo()
        {
            System.Console.WriteLine("How many people are playing?");
            string playerNumbers = Console.ReadLine ().ToLower ();
            //How do I make it look like this?:

            //How many people are playing?
            // 5
            //Enter player (1) name:
            //James
            //Enter player (2) name:
            // Jacob
            //....
            // Enter Number of holes being played:
            // 5 
            // Enter Par of hole (1):
            // 4
            // Enter James score:
            // 5
            //Enter Jacob score:
            //4
            //.....
            //Final score: James: 20, Jacob: 18
            // Par totals: 18
            // Jacob wins!
            // Play again? (y\n)
            
             
        }
    }
}