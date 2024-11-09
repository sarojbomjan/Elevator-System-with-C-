namespace Elevator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ElevatorDownBtn = new System.Windows.Forms.Button();
            this.ElevatorUpBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.GroundFloor_Btn = new System.Windows.Forms.Button();
            this.Floor1_Btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RightDoor_G = new System.Windows.Forms.PictureBox();
            this.LeftDoor_G = new System.Windows.Forms.PictureBox();
            this.MainElevator = new System.Windows.Forms.PictureBox();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.LiftUpTimer = new System.Windows.Forms.Timer(this.components);
            this.LiftDownTimer = new System.Windows.Forms.Timer(this.components);
            this.LeftDoor_T = new System.Windows.Forms.PictureBox();
            this.RightDoor_T = new System.Windows.Forms.PictureBox();
            this.OpenUpTimer = new System.Windows.Forms.Timer(this.components);
            this.CloseUpTimer = new System.Windows.Forms.Timer(this.components);
            this.OpenDownTimer = new System.Windows.Forms.Timer(this.components);
            this.CloseDownTimer = new System.Windows.Forms.Timer(this.components);
            this.FloorLabel = new System.Windows.Forms.Label();
            this.DeleteLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightDoor_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftDoor_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainElevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftDoor_T)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightDoor_T)).BeginInit();
            this.SuspendLayout();
            // 
            // ElevatorDownBtn
            // 
            this.ElevatorDownBtn.BackgroundImage = global::Elevator.Properties.Resources.ElevDownBtn;
            this.ElevatorDownBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ElevatorDownBtn.Location = new System.Drawing.Point(300, 186);
            this.ElevatorDownBtn.Name = "ElevatorDownBtn";
            this.ElevatorDownBtn.Size = new System.Drawing.Size(89, 55);
            this.ElevatorDownBtn.TabIndex = 12;
            this.ElevatorDownBtn.UseVisualStyleBackColor = true;
            this.ElevatorDownBtn.Click += new System.EventHandler(this.ElevatorDownBtn_Click);
            // 
            // ElevatorUpBtn
            // 
            this.ElevatorUpBtn.BackgroundImage = global::Elevator.Properties.Resources.elevUpBtn;
            this.ElevatorUpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ElevatorUpBtn.Location = new System.Drawing.Point(300, 100);
            this.ElevatorUpBtn.Name = "ElevatorUpBtn";
            this.ElevatorUpBtn.Size = new System.Drawing.Size(89, 55);
            this.ElevatorUpBtn.TabIndex = 11;
            this.ElevatorUpBtn.UseVisualStyleBackColor = true;
            this.ElevatorUpBtn.Click += new System.EventHandler(this.ElevatorUpBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox2.Location = new System.Drawing.Point(300, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 141);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = global::Elevator.Properties.Resources.DownButton;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Location = new System.Drawing.Point(516, 354);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(83, 73);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButon_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.BackgroundImage = global::Elevator.Properties.Resources.OpenButton;
            this.OpenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenButton.Location = new System.Drawing.Point(424, 354);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(83, 73);
            this.OpenButton.TabIndex = 8;
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // GroundFloor_Btn
            // 
            this.GroundFloor_Btn.BackgroundImage = global::Elevator.Properties.Resources.GButton;
            this.GroundFloor_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GroundFloor_Btn.Location = new System.Drawing.Point(459, 177);
            this.GroundFloor_Btn.Name = "GroundFloor_Btn";
            this.GroundFloor_Btn.Size = new System.Drawing.Size(83, 73);
            this.GroundFloor_Btn.TabIndex = 7;
            this.GroundFloor_Btn.UseVisualStyleBackColor = true;
            this.GroundFloor_Btn.Click += new System.EventHandler(this.GroundFloor_Btn_Click);
            // 
            // Floor1_Btn
            // 
            this.Floor1_Btn.BackgroundImage = global::Elevator.Properties.Resources._1Button;
            this.Floor1_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Floor1_Btn.Location = new System.Drawing.Point(459, 77);
            this.Floor1_Btn.Name = "Floor1_Btn";
            this.Floor1_Btn.Size = new System.Drawing.Size(83, 73);
            this.Floor1_Btn.TabIndex = 6;
            this.Floor1_Btn.UseVisualStyleBackColor = true;
            this.Floor1_Btn.Click += new System.EventHandler(this.Floor1_Btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Location = new System.Drawing.Point(424, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 463);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RightDoor_G
            // 
            this.RightDoor_G.BackgroundImage = global::Elevator.Properties.Resources.rightdoor;
            this.RightDoor_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RightDoor_G.Location = new System.Drawing.Point(188, 384);
            this.RightDoor_G.Name = "RightDoor_G";
            this.RightDoor_G.Size = new System.Drawing.Size(64, 182);
            this.RightDoor_G.TabIndex = 2;
            this.RightDoor_G.TabStop = false;
            this.RightDoor_G.Click += new System.EventHandler(this.RightDoor_G_Click);
            // 
            // LeftDoor_G
            // 
            this.LeftDoor_G.BackgroundImage = global::Elevator.Properties.Resources.leftdoor;
            this.LeftDoor_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftDoor_G.Location = new System.Drawing.Point(114, 385);
            this.LeftDoor_G.Name = "LeftDoor_G";
            this.LeftDoor_G.Size = new System.Drawing.Size(74, 182);
            this.LeftDoor_G.TabIndex = 1;
            this.LeftDoor_G.TabStop = false;
            this.LeftDoor_G.Click += new System.EventHandler(this.LeftDoor_G_Click);
            // 
            // MainElevator
            // 
            this.MainElevator.BackgroundImage = global::Elevator.Properties.Resources.elevat;
            this.MainElevator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainElevator.Location = new System.Drawing.Point(114, 385);
            this.MainElevator.Name = "MainElevator";
            this.MainElevator.Size = new System.Drawing.Size(138, 182);
            this.MainElevator.TabIndex = 0;
            this.MainElevator.TabStop = false;
            this.MainElevator.Click += new System.EventHandler(this.MainLift);
            // 
            // DataView
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.DataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(665, 8);
            this.DataView.Name = "DataView";
            this.DataView.RowHeadersWidth = 62;
            this.DataView.RowTemplate.Height = 28;
            this.DataView.Size = new System.Drawing.Size(525, 558);
            this.DataView.TabIndex = 13;
            this.DataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // LiftUpTimer
            // 
            this.LiftUpTimer.Interval = 50;
            this.LiftUpTimer.Tick += new System.EventHandler(this.LiftUpTimer_Tick);
            // 
            // LiftDownTimer
            // 
            this.LiftDownTimer.Interval = 50;
            this.LiftDownTimer.Tick += new System.EventHandler(this.LiftDownTimer_Tick);
            // 
            // LeftDoor_T
            // 
            this.LeftDoor_T.BackgroundImage = global::Elevator.Properties.Resources.leftdoor;
            this.LeftDoor_T.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftDoor_T.Location = new System.Drawing.Point(114, -1);
            this.LeftDoor_T.Name = "LeftDoor_T";
            this.LeftDoor_T.Size = new System.Drawing.Size(74, 182);
            this.LeftDoor_T.TabIndex = 14;
            this.LeftDoor_T.TabStop = false;
            this.LeftDoor_T.Click += new System.EventHandler(this.LeftDoor_T_Click);
            // 
            // RightDoor_T
            // 
            this.RightDoor_T.BackgroundImage = global::Elevator.Properties.Resources.rightdoor;
            this.RightDoor_T.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RightDoor_T.Location = new System.Drawing.Point(188, -1);
            this.RightDoor_T.Name = "RightDoor_T";
            this.RightDoor_T.Size = new System.Drawing.Size(64, 182);
            this.RightDoor_T.TabIndex = 15;
            this.RightDoor_T.TabStop = false;
            this.RightDoor_T.Click += new System.EventHandler(this.RightDoor_T_Click);
            // 
            // OpenUpTimer
            // 
            this.OpenUpTimer.Interval = 50;
            this.OpenUpTimer.Tick += new System.EventHandler(this.OpenDoorUp_Tick);
            // 
            // CloseUpTimer
            // 
            this.CloseUpTimer.Interval = 50;
            this.CloseUpTimer.Tick += new System.EventHandler(this.CloseDoorUp_Tick);
            // 
            // OpenDownTimer
            // 
            this.OpenDownTimer.Interval = 50;
            this.OpenDownTimer.Tick += new System.EventHandler(this.OpenDoorDown_Tick);
            // 
            // CloseDownTimer
            // 
            this.CloseDownTimer.Interval = 50;
            this.CloseDownTimer.Tick += new System.EventHandler(this.CloseDoorDown_Tick);
            // 
            // FloorLabel
            // 
            this.FloorLabel.AutoSize = true;
            this.FloorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FloorLabel.Location = new System.Drawing.Point(304, 8);
            this.FloorLabel.Name = "FloorLabel";
            this.FloorLabel.Size = new System.Drawing.Size(280, 52);
            this.FloorLabel.TabIndex = 16;
            this.FloorLabel.Text = "Current Floor";
            // 
            // DeleteLog
            // 
            this.DeleteLog.Location = new System.Drawing.Point(459, 471);
            this.DeleteLog.Name = "DeleteLog";
            this.DeleteLog.Size = new System.Drawing.Size(101, 39);
            this.DeleteLog.TabIndex = 17;
            this.DeleteLog.Text = "Delete";
            this.DeleteLog.UseVisualStyleBackColor = true;
            this.DeleteLog.Click += new System.EventHandler(this.DeleteLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1202, 568);
            this.Controls.Add(this.DeleteLog);
            this.Controls.Add(this.FloorLabel);
            this.Controls.Add(this.RightDoor_T);
            this.Controls.Add(this.LeftDoor_T);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.ElevatorDownBtn);
            this.Controls.Add(this.ElevatorUpBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.GroundFloor_Btn);
            this.Controls.Add(this.Floor1_Btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RightDoor_G);
            this.Controls.Add(this.LeftDoor_G);
            this.Controls.Add(this.MainElevator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightDoor_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftDoor_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainElevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftDoor_T)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightDoor_T)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainElevator;
        private System.Windows.Forms.PictureBox LeftDoor_G;
        private System.Windows.Forms.PictureBox RightDoor_G;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Floor1_Btn;
        private System.Windows.Forms.Button GroundFloor_Btn;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ElevatorUpBtn;
        private System.Windows.Forms.Button ElevatorDownBtn;
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.Timer LiftUpTimer;
        private System.Windows.Forms.Timer LiftDownTimer;
        private System.Windows.Forms.PictureBox LeftDoor_T;
        private System.Windows.Forms.PictureBox RightDoor_T;
        private System.Windows.Forms.Timer OpenUpTimer;
        private System.Windows.Forms.Timer CloseUpTimer;
        private System.Windows.Forms.Timer OpenDownTimer;
        private System.Windows.Forms.Timer CloseDownTimer;
        private System.Windows.Forms.Label FloorLabel;
        private System.Windows.Forms.Button DeleteLog;
    }
}

