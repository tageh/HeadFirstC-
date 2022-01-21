using System;

namespace Guy;

public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        double odds = .75;

        Guy Joe = new Guy("Joe", 100);
        Console.WriteLine("Welcome to the casino, The odds are " + odds);

        while (Joe.Cash > 0)
        {
            Joe.WriteMyInfo();

            Console.WriteLine("How much to you want to bet? ");
            string howMuch = Console.ReadLine();

            if (int.TryParse(howMuch, out int amount))
            {

                int pot = Joe.GiveCash(amount) * 2;

                if (pot > 0)
                {
                    if (random.NextDouble() > odds)
                    {
                        int winnings = pot;
                        Console.WriteLine("You win " + winnings);
                        Joe.ReciveCash(winnings);
                    }
                    else
                    {
                        Console.WriteLine("Bad luck, you lose!");
                    }
                }

            }else
            {
                Console.WriteLine("Enter a valid number!");
            }

        }
        Console.WriteLine("The house always wins!!");
    }
}