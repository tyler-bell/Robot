using System.Drawing;


namespace MyLittleRobot {
    class Robot2 : Robot {

        private int counter;            //add int for counter
        //private ArrayList log = new ArrayList();    //ArrayList to hold  

        //I was going to add both, but I saw the big capital OR so I didn't want to lose marks for not following spec

        public Robot2() : base() {      //default constructor

        }

        public int Counter { get => counter; set => counter = value; }
        
        public override void CheckRange(int spaces) {     //override Move method to include counter
            Point temp = Coords;                    //get Coords and set as temp Point
            base.CheckRange(spaces);                      //call original method
            if (temp != Coords) {                   //if new coords aren't the same as temp
                Counter += spaces;                  //increase counter because by goly, we've moved!
              //  string movement = "Direction: " + CurrentDirection + " Spaces: " + spaces;    //create string containing Direction and Spaces moved
              //  log.Add(movement);                                                            //add string to ArrayList
            }
        }
    }
    
}
