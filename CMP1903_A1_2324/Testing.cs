using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        public static void Main(string[] args)
        {
            TestDie();
            TestGame();
        }

        //Method to test the Die class
        private static void TestDie()
        {
            Die die = new Die();
            int rollValue = die.Roll();
            Debug.Assert(rollValue >= 1 && rollValue <= 6, "Die roll should e betweeen 1 and 6.");
            Console.WriteLine("Die roll test passed.");
        }
    }
}
