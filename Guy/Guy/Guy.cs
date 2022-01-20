using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guy
{
    internal class Guy
    {
        private string name;
        private int cash;

        public Guy(string name, int cash)
        {
            this.name = name;
            this.cash = cash;
        }

        public void WriteMyInfo()
        {
            Console.WriteLine(name + " has " + cash + " dollar");
        }

        public int GiveCash(int amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine("Are you kidding me? "+ amount + " dollar");
                return 0;
            }
            if(amount > cash)
            {
                Console.WriteLine("Its to much");
                return 0;
            }

            cash -= amount;
            return amount;
        }

        public void ReciveCash(int resivedCash)
        {
            if(resivedCash <= 0)
            {
                Console.WriteLine("Are you kidding me, thats nothing");
            }
            else
            {
                cash += resivedCash;
            }
        }


        public string Name { get; set; }
        public int Cash {
            get { return cash; } 
            
            set { cash += cash; } }
    }
}
