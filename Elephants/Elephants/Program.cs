using System;
namespace Elephants;

public class Program
{
    static void Main(string[] args)
    {
        Elephant lucinda = new Elephant("Lucinda", 33);
        Elephant lloyd = new Elephant("Lloyd", 40);
        Elephant lina = new Elephant("Lina", 30);
        
        Elephant[] elephants = new Elephant[] { lloyd, lucinda, lina };

        Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 tw swap, 4 to do something else, 5 to speak, 6 for extra");

        while (true)
        {
            char input = Console.ReadKey(true).KeyChar;
            Console.WriteLine("You pressed " + input);
            if(input == '1')
            {
                Console.WriteLine("Calling lloyd.WhoAmI()");
                lloyd.WhoAmI();
            }else if(input == '2')
            {
                Console.WriteLine("Calling lucinda.WhoAmI()");
                lucinda.WhoAmI();
            }else if (input == '3')
            {
                Elephant holder;
                holder = lloyd;
                lloyd = lucinda;
                lucinda = holder;
                Console.WriteLine("References has been swapped");
            }else if(input == '4')
            {
                lloyd = lucinda;
                lloyd.EarSize = 4321;
                lloyd.WhoAmI();
            }else if(input == '5')
            {
                lucinda.SpeakTo(lloyd, "Helloo mr.Lloyd");
            }else if(input == '6')
            {
                PrintElephant(elephants);

                Console.WriteLine("Who are you? ");
                string fromName = Console.ReadLine();
                int num1 = Convert.ToInt32(fromName);

                Console.WriteLine("Who do you want to speak to? ");
                string toName = Console.ReadLine();
                int num2 = Convert.ToInt32(toName);

                Elephant fromElephant = elephants[num1]; 
                Elephant toElephant = elephants[num2];
                Console.WriteLine("What is your message? ");
                string messageTo = Console.ReadLine();
                fromElephant.SpeakTo(toElephant, messageTo);
            }
            /*Ugly code, but it works xD*/
            else return;
            Console.WriteLine();
        }
    }

    static void PrintElephant(Elephant[] elephants)
    {
         Console.WriteLine("Elephants to choose from");
         for(int i = 0; i < elephants.Length; i++)
         {
            Console.WriteLine(elephants[i].Name+ " " + i);
         } 
    }
}