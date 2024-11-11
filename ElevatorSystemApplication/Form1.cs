
// Note: THE DATABASE code begins at line 314 if any changes is required...

using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Speech;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.Data;
using ElevatorControl;

namespace ElevatorSystemApplication
{
    public partial class Form1 : Form
    {
        //variables
        int elevatorTopPosition  = 63;
        int elevatorBottomPosition  = 376;
        int doorLeftClosedPosition  = 74;
        int doorLeftOpenPosition  = 12;
        int doorRightClosedPosition  = 139;
        int doorRightOpenPosition  = 200;

        bool isMovingUp  = false;
        bool isMovingDown  = false;

        bool isAtGroundFloor  = false;
        bool isAtFirstFloor  = false;

        //object 
        SpeechSynthesizer reader = new SpeechSynthesizer();
 


        public Form1()
        {
            InitializeComponent();
        }

        private void timer_lift_down_Tick(object sender, EventArgs e)
        {
            
            if (picture_lift.Top <= elevatorBottomPosition )
            {
                picture_lift.Top += 1;
            }
            else
            {
                timer_lift_down.Enabled = false;
                btn_up.Enabled = true;
                btn_1.Enabled = true;
                btn_close.Enabled = true;
                btn_open.Enabled = true;
                btn_down.BackColor = Color.White;
                btn_G.BackColor = Color.White;
                

                door_open_down();
                isAtGroundFloor  = true;

                picture_lift.Image = global::ElevatorControl.Properties.Resources.Inside_of_the_lift;

                display_panel.Image = global::ElevatorControl.Properties.Resources.G;
                display_top.Image = global::ElevatorControl.Properties.Resources.G;
                display_bottom.Image = global::ElevatorControl.Properties.Resources.G;
            }
        }

        private void timer_lift_up_Tick(object sender, EventArgs e)
        {
            if (picture_lift.Top >= elevatorTopPosition )
            {
                picture_lift.Top -= 1;
            }
            else
            {

                timer_lift_up.Enabled = false;
                btn_down.Enabled = true;
                btn_G.Enabled = true;
                btn_close.Enabled = true;
                btn_open.Enabled = true;
                btn_up.BackColor = Color.White;
                btn_1.BackColor = Color.White;

                door_open_up();
                isAtFirstFloor  = true;


                picture_lift.Image = global::ElevatorControl.Properties.Resources.Inside_of_the_lift;

                display_panel.Image = global::ElevatorControl.Properties.Resources._1;
                display_top.Image = global::ElevatorControl.Properties.Resources._1;
                display_bottom.Image = global::ElevatorControl.Properties.Resources._1;
            }
        }

        private void door_open_down_Tick(object sender, EventArgs e)
        {
            if (door_left_down.Left >= doorLeftOpenPosition  && door_right_down.Left <= doorRightOpenPosition )
            {
                door_left_down.Left -= 1;
                door_right_down.Left += 1;
            }
            else
            {

                timer_door_open_down.Enabled = false;

            }
        }

        private void door_close_down_Tick(object sender, EventArgs e)
        {
            if (door_left_down.Left <= doorLeftClosedPosition  && door_right_down.Left >= doorRightClosedPosition )
            {
                door_left_down.Left += 1;
                door_right_down.Left -= 1;
            }
            else
            {
                timer_door_close_down.Enabled = false;
                

                if (isMovingUp  == true)
                {
                    picture_lift.Image = global::ElevatorControl.Properties.Resources.lift_transparent;

                    display_panel.Image = global::ElevatorControl.Properties.Resources.up;
                    display_top.Image = global::ElevatorControl.Properties.Resources.up;
                    display_bottom.Image = global::ElevatorControl.Properties.Resources.up;

                    timer_lift_up.Enabled = true;
                    isMovingUp  = false;
                }
            }
        }

        private void timer_door_open_up_Tick(object sender, EventArgs e)
        {
            if (door_left_up.Left >= doorLeftOpenPosition  && door_right_up.Left <= doorRightOpenPosition )
            {
                door_left_up.Left -= 1;
                door_right_up.Left += 1;
            }
            else
            {
                timer_door_open_up.Enabled = false;

            }
        }

        private void timer_door_close_up_Tick(object sender, EventArgs e)
        {
            if (door_left_up.Left <= doorLeftClosedPosition  && door_right_up.Left >= doorRightClosedPosition )
            {
                door_left_up.Left += 1;
                door_right_up.Left -= 1;
            }
            else
            {
                timer_door_close_up.Enabled = false;

                
                if (isMovingDown  == true)
                {
                    picture_lift.Image = global::ElevatorControl.Properties.Resources.lift_transparent;

                    display_panel.Image = global::ElevatorControl.Properties.Resources.down;
                    display_top.Image = global::ElevatorControl.Properties.Resources.down;
                    display_bottom.Image = global::ElevatorControl.Properties.Resources.down;

                    
           

                    timer_lift_down.Enabled = true;
                    isMovingDown  = false;
                }
            }
        }

        private void door_close_down()
        {
            insertdata("Ground Floor Door's closed");
            timer_door_close_down.Enabled = true;
            timer_door_open_down.Enabled = false;
        }

        private void door_open_down()
        {
            insertdata("Ground Floor Door's opened");
            timer_door_close_down.Enabled = false;
            timer_door_open_down.Enabled = true;
        }

        private void door_close_up()
        {
            insertdata("First Floor Door's closed");
            timer_door_close_up.Enabled = true;
            timer_door_open_up.Enabled = false;
        }

        private void door_open_up()
        {
            insertdata("First Floor Door's opened");
            timer_door_close_up.Enabled = false;
            timer_door_open_up.Enabled = true;
        }

        private void going_up()
        {
            isMovingUp  = true;
            door_close_down();
            btn_G.Enabled = false;
            btn_down.Enabled = false;
            btn_close.Enabled = false;
            btn_open.Enabled = false;
            isAtGroundFloor  = false;
            insertdata("Lift proceeding to first floor");

        }


        private void going_down()
        {
            isMovingDown  = true;
            door_close_up();

            btn_1.Enabled = false;
            btn_up.Enabled = false;
            btn_close.Enabled = false;
            btn_open.Enabled = false;
            isAtFirstFloor  = false;
            insertdata("Lift proceeding to ground floor");

            
        }


        private void btn_down_Click(object sender, EventArgs e)
        {
            btn_up.BackColor = Color.Red;
            going_up();

        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            btn_down.BackColor = Color.Red;
            going_down();
        }


        private void btn_1_Click(object sender, EventArgs e)
        {
            btn_1.BackColor = Color.Red;
            going_up();
        }

        private void btn_G_Click(object sender, EventArgs e)
        {
            btn_G.BackColor = Color.OrangeRed;
            going_down();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (isAtGroundFloor  == true)
            {
                door_close_down();
            }
            else if (isAtFirstFloor  == true)
            {
                door_close_up();
            }

        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            if (isAtGroundFloor  == true)
            {
                door_open_down();
            }
            else if (isAtFirstFloor  == true)
            {
                door_open_up();
            }

        }

        private void btn_alarm_Click(object sender, EventArgs e)
        {
            btn_alarm.BackColor = Color.Green;
            reader.Speak("Emergency Stop. Please exit the lift carefully.");
            insertdata("Emergency Stop!");
            timer_lift_down.Enabled = false;
            timer_lift_up.Enabled = false;
            timer_door_open_down.Enabled = true;
            timer_door_open_up.Enabled = true;
            display_panel.Image = global::ElevatorControl.Properties.Resources.alarmbellbutton;
            display_top.Image = global::ElevatorControl.Properties.Resources.alarmbellbutton;
            display_bottom.Image = global::ElevatorControl.Properties.Resources.alarmbellbutton;

        }

       

        // Database

        private DB database = new DB();   

        private void btn_displaylog_Click(object sender, EventArgs e)
        {
            database.fetch_data(database_listbox);
        }

        private void insertdata(string action)
        {
            database.insertdata(action, database_listbox);
        }


        private void btn_clearlog_Click(object sender, EventArgs e)
        {
            database_listbox.Items.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}