using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elephants
{
    class Elephant
    {
        private int _earSize;
        private string _name;

        public Elephant(string name, int earSize)
        {
            this._name = name;
            this._earSize = earSize;
        }

        public void WhoAmI()
        {
            Console.WriteLine("My name is " + _name + ".");
            Console.WriteLine("My ears are " + _earSize + " inches tall.");
        }

        public void HearMessage(string message, Elephant whoSaidIt)
        {
            Console.WriteLine(_name + " heard a message");
            Console.WriteLine(whoSaidIt._name + " said this: " + message);
        }

        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.HearMessage(message, this);
        }

        public int EarSize
        {
            get { return _earSize; }
            set { _earSize = value; }
        }
        public string Name {
            get { return _name; }
            set { _name = value; } 
        }
    }
}
