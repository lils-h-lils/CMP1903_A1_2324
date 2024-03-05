using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{   /// <summary>
    /// Means a die with a face value that can be rolled
    /// </summary>
    internal class Die
    {
        /// <summary>
        /// Recieves the current face value of the die
        /// </summary>
        public int FaceValue { get; private set; }

        //Random number generator 
        private Random random;

        ///<summary>
        /// Initalises a new instance of 'Die' class
        /// </summary> 
        public Die()
        {
            random = new Random();
            Roll(); //Roll the die when it's created 
        }

        ///<summary>
        /// Rolls the die and sets its face value to a random number between 1 and 6 (inclusive).
        /// </summary> 
        /// <returns>The face value of the die after rolling</returns>
        public int Roll()
        {
            //Generate a random number between 1 and 6 (inclusive)
            FaceValue = random.Next(1, 7);
            return FaceValue;
        }

    }
}
