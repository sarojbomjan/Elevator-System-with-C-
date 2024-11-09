using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    internal class MovingDownState : ILiftState
    {
        public void MoveDown(Lift lift)
        {
            // Checks if the lift is at the ground floor level
            if (lift.MainLift.Top == 0 || lift.MainLift.Bottom < lift.FormSize)
            {
                lift.MainLift.Top += lift.LiftSpeed; // Move the lift down
                lift.Open.Enabled = false;
                lift.Close.Enabled = false;
            }
            else
            {
                
                lift.MainLift.Top = lift.FormSize - lift.MainLift.Height; // Correct position
                lift.SetState(new IdleState());
                lift.LiftTimerDown.Stop();


                lift.floorLabel.Text = "Arrived at Floor: 0";
                lift.CurrentFloor = 0;
                lift.Floor1Btn.BackColor = Color.White; // Reset button color
                lift.Floor1Btn.Enabled = true; // Enable buttons again
                lift.GroundFloorBtn.Enabled = true;
                lift.GodownBtn.Enabled = true;
                lift.GoupBtn.Enabled = true;
                lift.Open.Enabled = true;
                lift.Close.Enabled = true;
                lift.Open.PerformClick();
            }
        }


        public void MoveUp(Lift lift)
        { 
            /* Do nothing */
        }
    }
}
