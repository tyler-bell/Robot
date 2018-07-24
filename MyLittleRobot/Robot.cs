using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittleRobot {
    class Robot {
        public enum Direction { North, South, East, West };
        private Direction currentDirection;
        private Point coords;
        private int threshold = 100;
        public event EventHandler ThresholdReached;

        public Direction CurrentDirection { get => currentDirection; set => currentDirection = value; }
        public Point Coords { get => coords; set => coords = value; }
        public int Threshold { get => threshold; set => threshold = value; }


        public Robot(Point start) {
            Coords = start;
            CurrentDirection = Direction.North;
        }

        public void Move(int spaces) {
            switch(CurrentDirection) {
                case Direction.North:
                    coords.Offset(0, spaces);
                    break;
                case Direction.East:
                    coords.Offset(spaces, 0);
                    break;
                case Direction.South:
                    coords.Offset(0, -spaces);
                    break;
                case Direction.West:
                    coords.Offset(-spaces, 0);
                    break;
            }
            CheckRange();
        }

        private void CheckRange() {
            if (Coords.X > 100) {
                Coords = (Point) new Size(100,Coords.Y);
                OnThresholdReached(EventArgs.Empty);
            }
            if (Coords.X < -100) {
                Coords = (Point)new Size(-100, Coords.Y);
                OnThresholdReached(EventArgs.Empty);
            }
            if (Coords.Y > 100) {
                Coords = (Point)new Size(Coords.X, 100);
                OnThresholdReached(EventArgs.Empty);
            }
            if (Coords.Y < -100) {
                Coords = (Point)new Size(Coords.X, -100);
                OnThresholdReached(EventArgs.Empty);
            }
        }

        protected virtual void OnThresholdReached(EventArgs e) {
            EventHandler handler = ThresholdReached;
            if (handler != null) {
                handler(this, e);
            }
        }



    }
}
