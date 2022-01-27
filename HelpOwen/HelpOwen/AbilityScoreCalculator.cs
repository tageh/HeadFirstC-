using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpOwen
{
    class AbilityScoreCalculator
    {
        public int RollResult = 14;
        public double DevideBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score;


        public void CalculateAbilityScore()
        {
            double devided = RollResult / DevideBy;

            int added = AddAmount + (int)devided;

            if(added < Minimum)
            {
                Score = Minimum;
            }
            else
            {
                Score = added;
            }
        }
    }
}
