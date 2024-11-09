using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Elevator
{
    public partial class Form1 : Form
    {
        private DatabaseConnection dbConn;

        private Lift _lift;
        private Door _door;

        int doorSpeed = 3;
        int liftSpeed = 5;

        float doormaxwidth;

        DataTable db = new DataTable();

        public Form1()
        {
            InitializeComponent();

            dbConn = new DatabaseConnection();

            DataView.ColumnCount = 3; 
            DataView.Columns[0].Name = "ID"; // Column for ID
            DataView.Columns[1].Name = "Time"; // Column for Time
            DataView.Columns[2].Name = "Event"; // Column for Event

            db.Columns.Add("ID"); 
            db.Columns.Add("Time");
            db.Columns.Add("Event");

            displayDataFromDb();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _lift = new Lift(
                MainElevator,
                LeftDoor_G,     // Ground floor left door
                RightDoor_G,    // Ground floor right door
                LeftDoor_T,     // Top floor left door
                RightDoor_T,    // Top floor right door
                Floor1_Btn,
                GroundFloor_Btn,
                ElevatorUpBtn,
                ElevatorDownBtn,
                OpenButton,
                CloseButton,
                liftSpeed,
                this.ClientSize.Height,
                doorSpeed,
                LiftUpTimer,
                LiftDownTimer,
                FloorLabel
            );

            _door = new Door(
                    MainElevator,
                    LeftDoor_G,
                    RightDoor_G,
                    LeftDoor_T,
                    RightDoor_T,
                    Floor1_Btn,
                    GroundFloor_Btn,
                     ElevatorUpBtn,
                    ElevatorDownBtn,
                     OpenButton,
                     CloseButton,
                    doormaxwidth,
                 doorSpeed,
                     OpenUpTimer,
                CloseUpTimer,
                OpenDownTimer,
                    CloseDownTimer
                    );

            _door.DoorMaxWidth = 30;

        }

        private void LogEvents(string message)
        {
            DateTime currentTime = DateTime.Now;

            db.Rows.Add(currentTime, message);
            DataView.Rows.Add(currentTime, message);

            dbConn.InsertLogIntoDB(currentTime, message);
        }
        
        private void Floor1_Btn_Click(object sender, EventArgs e)
        {
            _lift.SetState(new MovingUpState());
            _lift.LiftTimerUp.Start();
            Floor1_Btn.Enabled = false;
            GroundFloor_Btn.Enabled = false; 
            ElevatorUpBtn.Enabled = false;
            ElevatorDownBtn.Enabled = false;
            OpenButton.Enabled = false;
            CloseButton.Enabled = false;

            FloorLabel.Text = "Current Floor: 1";

            LogEvents("Lift is arriving at floor 1");
        }

       

        private void GroundFloor_Btn_Click(object sender, EventArgs e)
        {
            _lift.SetState(new MovingDownState());

            _lift.LiftTimerDown.Start();
            Floor1_Btn.Enabled = false;
            GroundFloor_Btn.Enabled = false;
            ElevatorUpBtn.Enabled = false;
            ElevatorDownBtn.Enabled = false;
            OpenButton.Enabled = false;
            CloseButton.Enabled = false;

            FloorLabel.Text = "Current Floor: 0";

            LogEvents("Lift is arriving at ground floor");
        }


        private void LiftUpTimer_Tick(object sender, EventArgs e)
        {
            _lift.MoveUp();
        }

        private void LiftDownTimer_Tick(object sender, EventArgs e)
        {
            _lift.MoveDown();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {

            if(_lift.CurrentFloor == 1)
            {
                _door.SetState(new OpeningDoorState_Top());
                 OpenUpTimer.Start();
                Floor1_Btn.Enabled = false;
                GroundFloor_Btn.Enabled = false;
                ElevatorUpBtn.Enabled = false;
                ElevatorDownBtn.Enabled = false;

                LogEvents("Door of first floor is being opened!");

            }

            else
            {
                _door.SetState(new OpeningDoorState_Ground());
                OpenDownTimer.Start();
                Floor1_Btn.Enabled = false;
                GroundFloor_Btn.Enabled = false;
                ElevatorUpBtn.Enabled = false;
                ElevatorDownBtn.Enabled = false;

                LogEvents("Door of ground floor is being opened!");
            }
        }

        private void CloseButon_Click(object sender, EventArgs e)
        {
            if (_lift.CurrentFloor == 1)
            {
                _door.SetState(new ClosingDoorState_Top());
                CloseUpTimer.Start();
                Floor1_Btn.Enabled = false;
                GroundFloor_Btn.Enabled = false;
                ElevatorUpBtn.Enabled = false;
                ElevatorDownBtn.Enabled = false;

                LogEvents("Door of first floor is being closed!");

            }

            else
            {
                _door.SetState(new ClosingDoorState_Ground());
                CloseDownTimer.Start();
                Floor1_Btn.Enabled = false;
                GroundFloor_Btn.Enabled = false;
                ElevatorUpBtn.Enabled = false;
                ElevatorDownBtn.Enabled = false;

                LogEvents("Door of ground floor is being closed!");
            }
        }
     
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ElevatorUpBtn_Click(object sender, EventArgs e)
        {
            _lift.SetState(new MovingUpState());
            _lift.LiftTimerUp.Start();
            Floor1_Btn.Enabled = false;
            GroundFloor_Btn.Enabled = false;
            ElevatorUpBtn.Enabled = false;
            ElevatorDownBtn.Enabled = false;

            LogEvents("Lift is arriving at floor 1");
        }

        private void ElevatorDownBtn_Click(object sender, EventArgs e)
        {
            _lift.SetState(new MovingDownState());
            _lift.LiftTimerDown.Start();
            Floor1_Btn.Enabled = false;
            GroundFloor_Btn.Enabled = false;
            ElevatorUpBtn.Enabled = false;
            ElevatorDownBtn.Enabled = false;

            LogEvents("Lift is arriving at floor 1");
        }

        private void OpenDoorUp_Tick(object sender, EventArgs e)
        {
            _door.OpeningDoor();
        }
        private void CloseDoorUp_Tick(object sender, EventArgs e)
        {
            _door.ClosingDoor();
        }
        private void OpenDoorDown_Tick(object sender, EventArgs e)
        {
            _door.OpeningDoor();
        }

        private void CloseDoorDown_Tick(object sender, EventArgs e)
        {
            _door.ClosingDoor();
        }

        private void displayDataFromDb()
        {
            try
            {
                db = dbConn.FetchDataFromDb();
                DataView.Rows.Clear();

                foreach (DataRow row in db.Rows)
                {
                   
                    int id = Convert.ToInt32(row["ID"]); 
                    string currentTime = Convert.ToDateTime(row["logtime"]).ToString("hh:mm:ss");
                    string events = row["eventdescription"].ToString();

                  
                    DataView.Rows.Add(id, currentTime, events);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteSelectedLog()
        {
            if (DataView.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(DataView.SelectedRows[0].Cells["ID"].Value); // Get ID from the selected row

                // Call the method to delete the log by ID
                bool isDeleted = dbConn.DeleteLogById(selectedId);

                // Check if deletion was successful and show a message
                if (isDeleted)
                {
                    MessageBox.Show("Log deleted successfully!");
                    displayDataFromDb(); // Refresh DataGridView after deletion
                }
                else
                {
                    MessageBox.Show("No log entry found for the selected ID.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }



        private void DeleteLog_Click(object sender, EventArgs e)
        {
            DeleteSelectedLog();
        }
        private void MainLift(object sender, EventArgs e)
        {

        }


        private void LeftDoor_G_Click(object sender, EventArgs e)
        {

        }

        private void LeftDoor_T_Click(object sender, EventArgs e)
        {

        }

        private void RightDoor_G_Click(object sender, EventArgs e)
        {

        }

        private void RightDoor_T_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      
    }
}
