﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyLittleRobot {
    public partial class Form1 : Form {

        private static Point start = new Point(0, 0);        //start point to pass to the robot
        private Robot2 bob = new Robot2(start);             //creating an instance of the robot class
        private Point center;                               //creating a point to center the arrow

        public Form1() {
            InitializeComponent();
            this.Controls.Add(panel1);                      //adding the panel to the form's controls
            panel1.Controls.Add(label1);                    //adding the label1 (arrow) to the panel's controls
            SetArrow(bob.CurrentDirection);           //call method SetArrow passing the direction from bob
            DrawLabel();                                    //draw the arrow
            bob.ThresholdReached += bob_ThresholdReached;   //some shit to do with events
        }

        private void DrawLabel() {
            center = (Point)new Size((label1.Parent.Width / 2) - (label1.Width / 2) + bob.Coords.X, (label1.Parent.Height / 2) - (label1.Height / 2) - bob.Coords.Y);  //create center point by factoring in label size
            label1.Location = center;                                       //set label1 (arrow) position to center point
            label2.Text = "X: " + bob.Coords.X + "  Y: " + bob.Coords.Y;    //arrow's coords assuming center is 0,0
            label3.Text = "X: " + center.X + "  Y: " + center.Y;            //actual coords for where the arrow is being displayed within the panel
           // label4.Text = "Counter: " + bob.Counter;                      //label to test counter
        }
        private void northBTN_Click(object sender, EventArgs e) { //north button click
            bob.CurrentDirection = Robot.Direction.North;           //set direction of bob to north
            SetArrow(bob.CurrentDirection);                         //SetArrow to current direction
        }

        private void eastBTN_Click(object sender, EventArgs e) { //east button click
            bob.CurrentDirection = Robot.Direction.East;            //set direction of bob to east
            SetArrow(bob.CurrentDirection);                         //SetArrow to current direction
        }

        private void southBTN_Click(object sender, EventArgs e) { //south button click
            bob.CurrentDirection = Robot.Direction.South;           //set direction of bob to south
            SetArrow(bob.CurrentDirection);                         //SetArrow to current direction
        }

        private void westBTN_Click(object sender, EventArgs e) {  //west button click
            bob.CurrentDirection = Robot.Direction.West;            //set direction of bob to west
            SetArrow(bob.CurrentDirection);                         //SetArrow to current direction
        }

        private void move1_Click(object sender, EventArgs e) {   //move 1 button click
            bob.Move(1);                                            //call move from bob and pass 1
            DrawLabel();                                            //redraw label
        }

        private void move10_Click(object sender, EventArgs e) {     //move 10 button click
            bob.Move(10);                                               //call move from bob and pass 10
            DrawLabel();                                                //redraw label
        }
        private static void bob_ThresholdReached(object sender, EventArgs e) {
            MessageBox.Show("You've reached the boundary.");                    //display error when threshold event triggered
        }

        private void SetArrow(Robot.Direction direction) {     //method to set the proper arrow receiving the direction set in bob
            switch (direction) {                                    //switch case based on direction
                case Robot.Direction.North:                             //if north
                    label1.Text = char.ConvertFromUtf32(0x2191);            //draw north arrow
                    break;
                case Robot.Direction.South:                             //if south
                    label1.Text = char.ConvertFromUtf32(0x2193);            //draw south arrow
                    break;
                case Robot.Direction.East:                              //if east
                    label1.Text = char.ConvertFromUtf32(0x2192);            //draw east arrow
                    break; 
                case Robot.Direction.West:                              //if west
                    label1.Text = char.ConvertFromUtf32(0x2190);            //draw west arrow
                    break;
            }
        }
    }
}
