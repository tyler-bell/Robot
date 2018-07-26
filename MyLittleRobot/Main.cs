using System;
using System.Drawing;
using System.Windows.Forms;


namespace MyLittleRobot {
    public partial class Main : Form {
                
        private Robot bob = new Robot();             //creating an instance of the robot class

        public Main() {
            InitializeComponent();
            this.Controls.Add(DisplayPanel);                    //adding the panel to the form's controls
            DisplayPanel.Controls.Add(ArrowLBL);                //adding the label1 (arrow) to the panel's controls
            SetArrow(bob.CurrentDirection);                     //call method SetArrow passing the direction from bob
            UpdateDisplay();                                    //draw the arrow
            bob.BoundaryReached += bob_BoundaryReached;         //assigning delegates
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
            ArrowCoordsLBL.Text = "" + bob.Coords;    //arrow's coords assuming center is 0,0
            DisplayCoordsLBL.Text = "" + ArrowLBL.Location;          //display coords of the arrow within the panel
           // CounterLBL.Visible = true;                             //realized I could just hide and switch when on needed
           // CounterLBL.Text = "Counter: " + bob.Counter;             //label to test counter
        }

        private void SetArrow(Robot.Direction direction) {     //method to set the proper arrow receiving the direction set in bob
            switch (direction) {                                    //switch case based on direction
                case Robot.Direction.North:                             //if north
                    ArrowLBL.Text = char.ConvertFromUtf32(0xDD);            //draw north arrow
                    break;
                case Robot.Direction.South:                             //if south
                    ArrowLBL.Text = char.ConvertFromUtf32(0xDE);            //draw south arrow
                    break;
                case Robot.Direction.East:                              //if east
                    ArrowLBL.Text = char.ConvertFromUtf32(0xDC);            //draw east arrow
                    break; 
                case Robot.Direction.West:                              //if west
                    ArrowLBL.Text = char.ConvertFromUtf32(0xDB);            //draw west arrow
                    break;
            }
        }

        private static void bob_BoundaryReached(object sender, EventArgs e) {      //event handler for reaching the edge
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
            bob.CheckRange(1);                                            //call move from bob and pass 1
            UpdateDisplay();                                            //redraw label
        }
        private void move10_Click(object sender, EventArgs e) {     //move 10 button click
            bob.CheckRange(10);                                               //call move from bob and pass 10
            UpdateDisplay();                                                //redraw label
        }

        private void ExitButton_Click_1(object sender, EventArgs e) {   //close button
            this.Close();                                       //close app
        }



    }
}
