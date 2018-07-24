using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyLittleRobot {
    public partial class Main : Form {

        private static Point start = new Point(0, 0);       //start point to pass to the robot
        private Robot2 bob = new Robot2(start);             //creating an instance of the robot class
        private Point center;                               //creating a point to center the arrow

        public Main() {
            InitializeComponent();
            this.Controls.Add(DisplayPanel);                    //adding the panel to the form's controls
            DisplayPanel.Controls.Add(ArrowLBL);                //adding the label1 (arrow) to the panel's controls
            SetArrow(bob.CurrentDirection);                     //call method SetArrow passing the direction from bob
            UpdateDisplay();                                    //draw the arrow
            bob.ThresholdReached += bob_ThresholdReached;       //some shit to do with events
        }

        private void UpdateDisplay() {  //method to update display
            CalculateCenter();             //call method CalculateCenter
            DrawDisplayLabels();           //call method DrawDisplayLabels
        }
        
        private void CalculateCenter() {           //method to calculator center point
            int x = (DisplayPanel.Width / 2) - (ArrowLBL.Width / 2) + bob.Coords.X;      //Panel width /  2 - ArrowLBL width / 2 + Arrow Coords
            int y = (DisplayPanel.Height / 2) - (ArrowLBL.Height / 2) - bob.Coords.Y;    //Panel height /  2 - ArrowLBL height / 2 - Arrow Coords
            Size center = new Size(x, y);                                                //create size using x and y ints
            ArrowLBL.Location = (Point)center;                                           //set ArrowLBL location to center size casted as point
        }

        private void DrawDisplayLabels() {          //method to draw display labels
            ArrowCoordsLBL.Text = "X: " + bob.Coords.X + "  Y: " + bob.Coords.Y;    //arrow's coords assuming center is 0,0
            DisplayCoordsLBL.Text = "X: " + center.X + "  Y: " + center.Y;          //display coords of the arrow within the panel
            CounterLBL.Text = "Counter: " + bob.Counter;                            //label to test counter
        }

        private void SetArrow(Robot.Direction direction) {     //method to set the proper arrow receiving the direction set in bob
            switch (direction) {                                    //switch case based on direction
                case Robot.Direction.North:                             //if north
                    ArrowLBL.Text = char.ConvertFromUtf32(0x2191);            //draw north arrow
                    break;
                case Robot.Direction.South:                             //if south
                    ArrowLBL.Text = char.ConvertFromUtf32(0x2193);            //draw south arrow
                    break;
                case Robot.Direction.East:                              //if east
                    ArrowLBL.Text = char.ConvertFromUtf32(0x2192);            //draw east arrow
                    break; 
                case Robot.Direction.West:                              //if west
                    ArrowLBL.Text = char.ConvertFromUtf32(0x2190);            //draw west arrow
                    break;
            }
        }

        private static void bob_ThresholdReached(object sender, EventArgs e) {
            MessageBox.Show("You've reached the boundary.");                    //display error when threshold event triggered
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
            UpdateDisplay();                                            //redraw label
        }
        private void move10_Click(object sender, EventArgs e) {     //move 10 button click
            bob.Move(10);                                               //call move from bob and pass 10
            UpdateDisplay();                                                //redraw label
        }
    }
}
