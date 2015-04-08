using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipMania
{
    class Program
    {
        static void Main(string[] args)
        {
            FlipCoins(10000);

            FlipForHeads(10000);

            Console.ReadKey();
        }

        /// <summary>
        /// Calculates the number of times a coin flips heads and tails given a total 
        /// number of times to flip
        /// </summary>
        /// <param name="numberOfFlips">How many times to flip a coin</param>
        static void FlipCoins(int numberOfFlips)
        {
            int numHeads = 0;
            int numTails = 0;

            //create random number generator
            Random flip = new Random();

            //continue to flip coins for numberOfFlips amount of times
            for (int i = 0; i < numberOfFlips; i++)
            {
                if (flip.Next(0, 2) == 0)
                    numHeads++;
                else
                    numTails++;
            }

            Console.WriteLine("We flipped {0} times\nHeads: {1}\nTails: {2}", numberOfFlips, numHeads, numTails);
        }

        /// <summary>
        /// Uses a random number generator and calculates the number of flips it takes 
        /// to get a given number of heads
        /// </summary>
        /// <param name="numberOfHeads">How many "heads" to want to flip for</param>
        static void FlipForHeads(int numberOfHeads)
        {
            int numberOfHeadsFlipped = 0;
            int totalFlips = 0;

            //create random number generator
            Random flip = new Random();

            //loop for flipping coin until given number of heads is received
            while (numberOfHeadsFlipped != numberOfHeads)
            {
                if (flip.Next(0, 2) == 0)
                    numberOfHeadsFlipped++;
                totalFlips++;
            }

            Console.WriteLine("We are flipping a coin until we find {0} heads", numberOfHeads);
            Console.WriteLine("It took {0} flips to find {1} heads", totalFlips, numberOfHeads);
        }
    }
}
