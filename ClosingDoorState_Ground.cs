using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    internal class ClosingDoorState_Ground : IDoorState
    {
        public void ClosingDoor(Door door)
        {
            if (door.LeftDoorG.Left < door.MainLift.Left)
            {
                door.LeftDoorG.Left += door.DoorSpeed;
                door.RightDoorG.Left -= door.DoorSpeed;
            }
            else
            {
                door.CloseGround.Stop();
               
                door.Floor1.Enabled = true;
                door.GroundFloor.Enabled = true;
                door.GoupBtn.Enabled = true;
                door.GodownBtn.Enabled = true;

                door._currentState = new DoorIdleState();
            }

        }
        public void OpeningDoor(Door door)
        {
            // Do nothing, cannot open while closing
        }


    }
}
