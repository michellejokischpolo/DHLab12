using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLab12
{
    class Michelle : Player
    {
        public Michelle(RPSGenerator r) : base(r)

        {

            name = "rock";
            name = "paper";
            name = "scissors";


        }

        public override string GenerateRPS()
        {
            throw new NotImplementedException();
        }
    }
}
