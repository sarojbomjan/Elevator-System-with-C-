using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    internal class OpeningDoorState_Top : IDoorState
    {
        public void ClosingDoor(Door door)
        {

        }

        public void OpeningDoor(Door door)
        {

            if (door.LeftDoorT.Left > door.MainLift.Left - door.DoorMaxWidth)
            {
                door.LeftDoorT.Left -= door.DoorSpeed;
                door.RightDoorT.Left += door.DoorSpeed;
            }

            else
            {
                door.OpenTop.Stop();
                door._currentState = new DoorIdleState();
                door.Floor1.Enabled = false;
                door.GroundFloor.Enabled = false;
                door.GodownBtn.Enabled = false;
                door.GoupBtn.Enabled = false;
            }
        }

    }
}
