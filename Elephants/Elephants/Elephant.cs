using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elephants
{
    class Elephant
    {
        //private int earSize;
        //private string name;

        public Elephant(string name, int earSize)
        {
            this.Name = name;
            this.EarSize = earSize;
        }

        public void WhoAmI()
        {
            Console.WriteLine("My name is " + Name + ".");
            Console.WriteLine("My ears are " + EarSize + " inches tall.");
        }

        public void HearMessage(string message, Elephant whoSaidIt)
        {
            Console.WriteLine(Name + " heard a message");
            Console.WriteLine(whoSaidIt.Name + " said this: " + message);
        }

        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.HearMessage(message, this);
        }

        public int EarSize{get; set;}
        public string Name {get; set;}
    }
}
