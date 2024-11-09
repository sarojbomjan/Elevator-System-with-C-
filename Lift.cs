using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator
{
    public class Lift
    {

        public ILiftState _CurrentState;

        public PictureBox MainLift;
        public PictureBox LeftDoorG;
        public PictureBox RightDoorG;
        public PictureBox LeftDoorT;
        public PictureBox RightDoorT;
        public Button Floor1Btn;
        public Button GroundFloorBtn;
        public Button GoupBtn;
        public Button GodownBtn;
        public Button Open;
        public Button Close;
        public int LiftSpeed;
        public int FormSize;
        public int DoorSpeed;
        public Timer LiftTimerUp;
        public Timer LiftTimerDown;

        public Label floorLabel;

        public int CurrentFloor = 0;

        public Lift(PictureBox MainElevator, PictureBox LeftDoor_G, PictureBox RightDoor_G, PictureBox LeftDoor_T, PictureBox RightDoor_T, Button Floor1_Btn, Button GroundFloor_Btn, Button ElevatorUpBtn, Button ElevatorDownBtn,Button OpenButton, Button CloseButton, int liftSpeed, int formSize, int doorSpeed, Timer LiftUpTimer, Timer LiftDownTimer, Label FloorLabel)
        {
            MainLift = MainElevator;
            LeftDoorG = LeftDoor_G;
            RightDoorG = RightDoor_G;
            LeftDoorT = LeftDoor_T;
            RightDoorT = RightDoor_T;
            Floor1Btn = Floor1_Btn;
            GroundFloorBtn = GroundFloor_Btn;
            GoupBtn = ElevatorUpBtn;
            GodownBtn = ElevatorDownBtn;
            Open = OpenButton;
            Close = CloseButton;
            LiftSpeed = liftSpeed;
            FormSize = formSize;
            DoorSpeed = doorSpeed;
            LiftTimerUp = LiftUpTimer;
            LiftTimerDown = LiftDownTimer;
            floorLabel = FloorLabel;
   
            _CurrentState = new IdleState();

        }

        public void SetState(ILiftState state)
        {
            _CurrentState = state;
        }
        public void MoveUp()
        {
            _CurrentState.MoveUp(this);
        }

        public void MoveDown()
        {
            _CurrentState.MoveDown(this);
        }

    }
}
