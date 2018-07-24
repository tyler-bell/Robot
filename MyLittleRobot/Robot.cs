using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittleRobot {
    class Robot {

        public enum Direction { North, South, East, West };         //enum of possible directions
        private Direction currentDirection;                         //Direction to hold currentDirection
        private Point coords;                                       //arrows position stored as Point
        private int threshold = 100;                                //threshold of Threshold
        public event EventHandler ThresholdReached;                 //event for reaching threshold

        public Direction CurrentDirection { get => currentDirection; set => currentDirection = value; }
        public Point Coords { get => coords; set => coords = value; }
        public int Threshold { get => threshold; set => threshold = value; }


        public Robot() {         //constructor receiving starting Point
            Coords = new Point(0, 0);               //create new point of 0,0 for coords
            CurrentDirection = Direction.North;     //set direction to North
        }

        public Robot(Point start, Direction cardinal) {         //constructor receiving starting Point
            Coords = start;                         //set starting point to coords
            CurrentDirection = cardinal;            //set direction to cardinal
        }
        
        public virtual void Move(int spaces) {      //method to move the arrow
            switch(CurrentDirection) {                  //switch case based on CurrentDirection
                case Direction.North:                       //if north
                    coords.Offset(0, spaces);                   //offset y by positive spaces
                    break;
                case Direction.East:                        //if east
                    coords.Offset(spaces, 0);                   //offset x by positive spaces 
                    break;
                case Direction.South:                       //if south
                    coords.Offset(0, -spaces);                  //offset y by negative spaces
                    break;
                case Direction.West:                        //if west
                    coords.Offset(-spaces, 0);                  //offset x by negative spaces
                    break;
            }
            CheckRange();                               //call CheckRange method to ensure we're within bounds
        }

        private void CheckRange() {                 //method to ensure we're in bounds
            if (Coords.X > Threshold) {                 //if X position is greater than threshold (100)
                Coords = (Point) new Size(Threshold,Coords.Y);  //set coords to 100,Coords.Y
                OnThresholdReached(EventArgs.Empty);            //throw event
            }
            if (Coords.X < -Threshold) {                //if X position is less than negative threshold (-100)
                Coords = (Point)new Size(-Threshold, Coords.Y); //set coords to -100,Coords.Y
                OnThresholdReached(EventArgs.Empty);            //throw event
            }
            if (Coords.Y > Threshold) {                 //if Y position is greater than threshold (100)
                Coords = (Point)new Size(Coords.X, Threshold);  //set coords to Coords.X,100
                OnThresholdReached(EventArgs.Empty);            //throw event
            }
            if (Coords.Y < -Threshold) {                //if Y position is less than negative threshold (-100)
                Coords = (Point)new Size(Coords.X, -Threshold); //set coords to Coords.X,-100
                OnThresholdReached(EventArgs.Empty);            //throw event
            }
        }

        protected virtual void OnThresholdReached(EventArgs e) {        //event handler
            EventHandler handler = ThresholdReached;
            if (handler != null) {
                handler(this, e);
            }
        }
    }
}
