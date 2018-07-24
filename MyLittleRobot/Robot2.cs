using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittleRobot {
    class Robot2 : Robot {

        private int counter;

        public Robot2(Point start) : base(start) {

        }

        public int Counter { get => counter; set => counter = value; }
        
        public override void Move(int spaces) {
            Point temp = Coords;
            base.Move(spaces);
            if (temp != Coords) {
                Counter += spaces;
            }
        }
    }
    
}
