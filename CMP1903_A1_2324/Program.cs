using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{   /// <summary>
    /// Tests the functionality of the 'Game','Die' and 'Testing' class
    /// </summary>
    internal class Program
    {   /// <summary>
        /// Entry point of the program
        /// </summary>
        /// <param name="args">Command Line arguments.</param>
        static void Main(string[] args)
        {
            //Create a Game object and call its methods 
            Game game = new Game();
            int total = game.RollDice();

            //Create a Testing object to verify the output and operation of the other classes
            Testing.TestDie();
            Testing.TestGame();

            //Waiting for the user input 
            Console.WriteLine("Press and key to exit...");
            Console.ReadLine();

        }
    }
}
