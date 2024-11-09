using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    internal class ClosingDoorState_Top : IDoorState
    {
        public void ClosingDoor(Door door)
        {
            if (door.LeftDoorT.Left < door.MainLift.Left)
            {
                door.LeftDoorT.Left += door.DoorSpeed;
                door.RightDoorT.Left -= door.DoorSpeed;
            }
            else
            {
                door.CloseTop.Stop();
                door.Floor1.Enabled = true;
                door.GroundFloor.Enabled = true;
                door.GodownBtn.Enabled = true;
                door.GoupBtn.Enabled = true;

                door._currentState = new DoorIdleState();
            }
        }

        public void OpeningDoor(Door door)
        {

        }
    }
}
