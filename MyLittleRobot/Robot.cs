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

        public Direction CurrentDirection { get => currentDirection; set => currentDirection = value; }
        public Point Coords { get => coords; set => coords = value; }

        public Robot(Point start) {
            Coords = start;
            CurrentDirection = Direction.North;
        }

        public void Move(int spaces) {
            switch(CurrentDirection) {
                case Direction.North:
                    if (spaces == 1) {
                        coords.Offset(0, 1); 
                    } else {
                        coords.Offset(0, 10);
                    }

                    break;
                case Direction.East:
                    if (spaces == 1) {
                        coords.Offset(1, 0);
                    } else {
                        coords.Offset(10, 0);
                    }
                    break;
                case Direction.South:
                    if (spaces == 1) {
                        coords.Offset(0, -1);
                    } else {
                        coords.Offset(0, -10);
                    }
                    break;
                case Direction.West:
                    if (spaces == 1) {
                        coords.Offset(-1, 0);
                    } else {
                        coords.Offset(-10, 0);
                    }
                    break;
                default:
                    break;
            }
            CheckRange();
        }

        private void CheckRange() {
            if (Coords.X > 100) {
                Coords = (Point) new Size(100,Coords.Y);
            }
            if (Coords.X < -100) {
                Coords = (Point)new Size(-100, Coords.Y);
            }
            if (Coords.Y > 100) {
                Coords = (Point)new Size(Coords.X, 100);
            }
            if (Coords.Y < -100) {
                Coords = (Point)new Size(Coords.X, -100);
            }
        }


    }
}
