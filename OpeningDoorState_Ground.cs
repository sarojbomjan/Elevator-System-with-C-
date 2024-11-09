using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    internal class OpeningDoorState_Ground : IDoorState
    {
        public void OpeningDoor(Door door)
        {
            if (door.LeftDoorG.Left > door.MainLift.Left - door.DoorMaxWidth)
            {
                door.LeftDoorG.Left -= door.DoorSpeed;
                door.RightDoorG.Left += door.DoorSpeed;
            }

            else
            {
                door.OpenGround.Stop();
                door._currentState = new DoorIdleState();
                door.Floor1.Enabled = false;
                door.GroundFloor.Enabled = false;
                door.GoupBtn.Enabled = false;
                door.GodownBtn.Enabled = false;
            }
        }

        public void ClosingDoor(Door door)
        {
            // Do nothing, cannot close while opening
        }
    }
}
