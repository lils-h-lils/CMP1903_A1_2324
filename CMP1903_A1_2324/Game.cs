using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324

{   /// <summary>
    /// Shows a game with three dice
    /// </summary>
    internal class Game
    {
        //Contains an array of Die objects to represent the three dice.
        private Die[] dice;

        /// <summary>
        /// Initialises a new instance of the 'Game' class
        /// </summary>
        public Game()
        {
            dice = new Die[3];
            for (int i=0; i<3; i++) 
            {
                dice[i] = new Die();
            }
        }

        /// <summary>
        /// Rolls all three dice, sums their values, and reports the total.
        /// </summary>
        /// <returns>Total value of three dice rolls.</returns>
        public int RollDice()
        {
            int total = 0;
            foreach (Die die in dice)
            {
                total += die.Roll();
            }
            Console.WriteLine($"Total of the three dice rolls: {total}");
            return total;
        }

    }
}
