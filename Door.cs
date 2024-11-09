using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Elevator
{
    public class Door
    {
        public IDoorState _currentState;

        public PictureBox MainLift;
        public PictureBox LeftDoorG;
        public PictureBox RightDoorG;
        public PictureBox LeftDoorT;
        public PictureBox RightDoorT;
        public Button Floor1;
        public Button GroundFloor;
        public Button GoupBtn;
        public Button GodownBtn;
        public Button Open;
        public Button Close;
        public double DoorMaxWidth;
        public int DoorSpeed;
        public Timer OpenTop;
        public Timer CloseTop;
        public Timer OpenGround;
        public Timer CloseGround;

        public Door(PictureBox MainElevator, PictureBox LeftDoor_G, PictureBox RightDoor_G, PictureBox LeftDoor_T, PictureBox RightDoor_T, Button Floor1_Btn, Button GroundFloor_Btn, Button ElevatorUpBtn, Button ElevatorDownBtn,Button OpenButton, Button CloseButton, double doorMaxWidth, int doorSpeed, Timer OpenUpTimer, Timer CloseUpTimer, Timer OpenDownTimer, Timer CloseDownTimer)
        {
            MainLift = MainElevator;
            LeftDoorG = LeftDoor_G;
            RightDoorG = RightDoor_G;
            LeftDoorT = LeftDoor_T;
            RightDoorT = RightDoor_T;
            Floor1 = Floor1_Btn;
            GroundFloor = GroundFloor_Btn;
            GoupBtn = ElevatorUpBtn;
            GodownBtn = ElevatorDownBtn;
            Open = OpenButton;
            Close = CloseButton;
            DoorMaxWidth = doorMaxWidth;
            DoorSpeed = doorSpeed;
            OpenTop = OpenUpTimer;
            CloseTop = CloseUpTimer ;
            OpenGround = OpenDownTimer;
            CloseGround = CloseDownTimer;
      
        }

        public void SetState(IDoorState state)
        {
            _currentState = state;
        }

        public void OpeningDoor()
        {
            _currentState.OpeningDoor(this);
        }

        public void ClosingDoor()
        {
            _currentState.ClosingDoor(this);
        }
    }
}
