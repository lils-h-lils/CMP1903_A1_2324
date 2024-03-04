﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        //Method to test the Die class
        public static void TestDie()
        {
            Die die = new Die();
            int rollValue = die.Roll();
            Debug.Assert(rollValue >= 1 && rollValue <= 6, "Die roll should e betweeen 1 and 6.");
            Console.WriteLine("Die roll test passed.");
        }

        //Method to test the Game class
        public static void TestGame()
        {
            Game game = new Game();
            int total = game.RollDice();
            Debug.Assert(total >= 3 && total <= 18, "Sum of dice rolls should be between 3 and 18");
            Console.WriteLine("Game test passed.");
        }
    }
}
