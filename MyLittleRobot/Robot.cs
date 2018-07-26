using System;
using System.Drawing;


namespace MyLittleRobot {
    class Robot {

        public enum Direction { North, South, East, West };         //enum of possible directions
        private Direction currentDirection;                         //Direction to hold currentDirection
        private Point coords;                                       //arrows position stored as Point
        private int boundary = 100;                                //Boundary of Boundary
        public event EventHandler BoundaryReached;                 //event for reaching Boundary

        public Direction CurrentDirection { get => currentDirection; set => currentDirection = value; }
        public Point Coords { get => coords; set => coords = value; }
        public int Boundary { get => boundary; set => boundary = value; }


        public Robot() {         //constructor receiving starting Point
            Coords = new Point(0, 0);               //create new point of 0,0 for coords
            CurrentDirection = Direction.North;     //set direction to North
        }

        public Robot(Point start, Direction cardinal) {         //constructor receiving starting Point
            Coords = start;                         //set starting point to coords
            CurrentDirection = cardinal;            //set direction to cardinal
        }
        
        private void Move(int spaces) {      //method to move the arrow
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
        }

        public virtual void CheckRange(int spaces) {                 //method to ensure we're in bounds
            switch (CurrentDirection) {                  //switch case based on CurrentDirection
                case Direction.North:                       //if north
                    if (Coords.Y + spaces > Boundary) {     //get Y position, add spaces and see if we're outside the boundary
                        OnBoundaryReached(EventArgs.Empty);             //if so throw event
                    } else {
                        Move(spaces);                                   //otherwise call move passing spaces
                    }
                    break;
                case Direction.East:                        //if east
                    if (Coords.X + spaces > Boundary) {     //get X position, add spaces and see if we're outside the boundary
                        OnBoundaryReached(EventArgs.Empty);            //if so throw event
                    } else {
                        Move(spaces);                                   //otherwise call move passing spaces
                    }
                    break;
                case Direction.South:                       //if south
                    if (Coords.Y - spaces < -Boundary) {     //get Y position, less spaces and see if we're outside the boundary
                        OnBoundaryReached(EventArgs.Empty);            //if so throw event
                    } else {
                        Move(spaces);                                   //otherwise call move passing spaces
                    }
                    break;
                case Direction.West:                        //if west
                    if (Coords.X - spaces < -Boundary) {     //get X position, less spaces and see if we're outside the boundary
                        OnBoundaryReached(EventArgs.Empty);            //if so throw event
                    } else {
                        Move(spaces);                                   //otherwise call move passing spaces
                    }
                    break;
            }
        }

        protected virtual void OnBoundaryReached(EventArgs e) {        //event handler
            EventHandler handler = BoundaryReached;                    //instantiate the event
            handler(this, e);                                          //call the event
        }


    }
}
