using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        //Property to hold the current die value
        public int FaceValue { get; private set; }

        //Random number generator 
        private Random random;

        //Constructor 
        public Die()
        {
            random = new Random();
            Roll(); //Roll the die when it's created 
        }

        //Method to roll the die 
        public int Roll()
        {

        }

    }
}
