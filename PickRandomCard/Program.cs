using System;

namespace PickRandomCards;

public class PickRandomCards
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of cards you want: ");
        string line = Console.ReadLine();

        if (int.TryParse(line, out int numberOfCards))
        {
            foreach (string card in CardPicker.PickSomeCards(numberOfCards))
            {
                Console.WriteLine(card);
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }
}