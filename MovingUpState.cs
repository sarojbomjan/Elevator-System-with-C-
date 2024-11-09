using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    internal class MovingUpState : ILiftState
    {

        public void MoveDown(Lift lift)
        {

        }
        public void MoveUp(Lift lift)
        {

            // Checks if the lift has not yet reached the top of the form
            if (lift.MainLift.Top > 0)
            {
                lift.MainLift.Top -= lift.LiftSpeed; // Move the lift up
                lift.Open.Enabled = false;
                lift.Close.Enabled = false;
            }
            else
            {
               
                lift.MainLift.Top = 0; // Set the position to the top
                lift.SetState(new IdleState());
                lift.CurrentFloor = 1;
                lift.LiftTimerUp.Stop(); // Stop the upward timer

                lift.floorLabel.Text = "Arrived at Floor: 1";
                lift.Floor1Btn.BackColor = Color.White;
                lift.Floor1Btn.Enabled = true;
                lift.GroundFloorBtn.Enabled = true;
                lift.GoupBtn.Enabled = true;
                lift.GodownBtn.Enabled = true;
                lift.Open.Enabled  = true;
                lift.Close.Enabled = true;
                lift.Open.PerformClick();

            }
        }
    }
}