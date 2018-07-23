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
    public partial class Form1 : Form {
        public static Point start = new Point(0, 0);
        private Robot bob = new Robot(start);
        private Point center;
        public Form1() {
            InitializeComponent();
            this.Controls.Add(panel1);
            panel1.Controls.Add(label1);
            CheckDirection(bob.CurrentDirection);
            DrawLabel();
            bob.ThresholdReached += bob_ThresholdReached;
        }

        private void DrawLabel() {
            center = (Point)new Size((label1.Parent.Width / 2) - (label1.Width / 2) + bob.Coords.X, (label1.Parent.Height / 2) - (label1.Height / 2) - bob.Coords.Y);
            label1.Location = center;
            label2.Text = "X: " + bob.Coords.X + "  Y: " + bob.Coords.Y; 
            label3.Text = "X: " + center.X + "  Y: " + center.Y;
            label4.Text = "Width: " + label1.Width + " Height: " + label1.Height;
        }
        private void northBTN_Click(object sender, EventArgs e) { //227
            bob.CurrentDirection = Robot.Direction.North;
            CheckDirection(bob.CurrentDirection);
        }

        private void eastBTN_Click(object sender, EventArgs e) { //226
            bob.CurrentDirection = Robot.Direction.East;
            CheckDirection(bob.CurrentDirection);
        }

        private void southBTN_Click(object sender, EventArgs e) { //228
            bob.CurrentDirection = Robot.Direction.South;
            CheckDirection(bob.CurrentDirection);
        }

        private void westBTN_Click(object sender, EventArgs e) {  //225
            bob.CurrentDirection = Robot.Direction.West;
            CheckDirection(bob.CurrentDirection);
        }

        private void move1_Click(object sender, EventArgs e) {
            bob.Move(1);
            DrawLabel();
        }

        private void move10_Click(object sender, EventArgs e) {
            bob.Move(10);
            DrawLabel();
        }
        private static void bob_ThresholdReached(object sender, EventArgs e) {
            MessageBox.Show("You've reached the boundary.");
        }

        private void CheckDirection(Robot.Direction direction) {
            switch (direction) {
                case Robot.Direction.North:
                    label1.Text = char.ConvertFromUtf32(0x2191);
                    break;
                case Robot.Direction.South:
                    label1.Text = char.ConvertFromUtf32(0x2193);
                    break;
                case Robot.Direction.East:
                    label1.Text = char.ConvertFromUtf32(0x2192);
                    break;
                case Robot.Direction.West:
                    label1.Text = char.ConvertFromUtf32(0x2190);
                    break;
            }
        }
    }
}
