using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    internal class IdleState : ILiftState
    {
        public void MoveDown(Lift lift)
        {
            /* Do Nothing */
        }

        public void MoveUp(Lift lift)
        {
            /* Do Nothing */
        }
    }
}
