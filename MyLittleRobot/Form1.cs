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
        public Form1() {
            InitializeComponent();

        }
        private void northBTN_Click(object sender, EventArgs e) {
            moveNorth();
        }

        private void eastBTN_Click(object sender, EventArgs e) {
            moveEast();
        }

        private void southBTN_Click(object sender, EventArgs e) {
            moveSouth();
        }

        private void westBTN_Click(object sender, EventArgs e) {
            moveWest();
        }

        private void move1_Click(object sender, EventArgs e) {
            move(1);
        }

        private void move10_Click(object sender, EventArgs e) {
            move(10);
        }
    }
}
