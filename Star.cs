using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLab12
{
    class Star: Player
    {
        public Star(RPSGenerator r) : base (r) {
        
                name = "rock";
                name = "paper";
                name = "scissors";

            
        }
       

        public override string GenerateRPS() //this comes from the RPS class, this will always get index 0 -- or rock
        {
            Random randomStar = new Random();
            int i = randomStar.Next(0, 3);
            return rpsList.GetByIndex(i);
        }
    }
}



   
