using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        //Contains an array of Die objects to represent the three dice.
        private Die[] dice;

        //Constructor
        public Game()
        {
            dice = new Die[3];
            for (int i=0; i<3; i++) 
            {
                dice[i] = new Die();
            }
        }

        //Method to roll all three dice, sum their values and report the total
        public int RollDice()
        {
            int total = 0;
            foreach (Die die in dice)
            {
                total += die.Roll();
            }
        }

    }
}
