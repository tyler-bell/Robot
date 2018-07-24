using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittleRobot {
    class Robot2 : Robot {

        private int counter;            //add int for counter

        public Robot2() : base() {      //default constructor

        }

        public int Counter { get => counter; set => counter = value; }
        
        public override void Move(int spaces) {     //override Move method to include counter
            Point temp = Coords;                    //get Coords and set as temp Point
            base.Move(spaces);                      //call original method
            if (temp != Coords) {                   //if new coords aren't the same as temp
                Counter += spaces;                  //increase counter because by goly, we've moved!
            }
        }
    }
    
}
