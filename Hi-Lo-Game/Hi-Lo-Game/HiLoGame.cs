using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Lo_Game
{
    static class HiLoGame
    {
        public const int MAXIMUM = 10;
        private static Random random = new Random();    
        private static int currentNumber = random.Next(1, MAXIMUM+1);
        private static int pot = 10;

        public static int GetPot() { return pot; }

        public static void Guess(bool higher)
        {
            int nextNumber = random.Next(1, MAXIMUM+1);
            if ((higher && nextNumber >= currentNumber) || (!higher && nextNumber <= currentNumber))
            {
                Console.WriteLine("You guesses right");
                pot++;
            }
            else
            {
                Console.WriteLine("Bad luck, you guesses wrong");
                pot--;
            }

            currentNumber = nextNumber;
            Console.WriteLine($"Current number is now {currentNumber}");

        }

        public static void Hint()
        {
            int half = MAXIMUM / 2;

            if(currentNumber >= half)
            {
                Console.WriteLine($"The number is atleast {half}");
            }
            else
            {
                Console.WriteLine($"The number is at most {half}");
            }
            pot--;
        }
    }
}
