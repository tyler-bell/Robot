namespace MyLittleRobot {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.ArrowLBL = new System.Windows.Forms.Label();
            this.NorthBTN = new System.Windows.Forms.Button();
            this.WestBTN = new System.Windows.Forms.Button();
            this.SouthBTN = new System.Windows.Forms.Button();
            this.EastBTN = new System.Windows.Forms.Button();
            this.Move1 = new System.Windows.Forms.Button();
            this.Move10 = new System.Windows.Forms.Button();
            this.ArrowCoordsLBL = new System.Windows.Forms.Label();
            this.DisplayCoordsLBL = new System.Windows.Forms.Label();
            this.CounterLBL = new System.Windows.Forms.Label();
            this.DisplayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayPanel.Controls.Add(this.ArrowLBL);
            this.DisplayPanel.Location = new System.Drawing.Point(13, 27);
            this.DisplayPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(227, 222);
            this.DisplayPanel.TabIndex = 0;
            // 
            // ArrowLBL
            // 
            this.ArrowLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ArrowLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ArrowLBL.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrowLBL.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ArrowLBL.Location = new System.Drawing.Point(13, 11);
            this.ArrowLBL.Margin = new System.Windows.Forms.Padding(0);
            this.ArrowLBL.Name = "ArrowLBL";
            this.ArrowLBL.Size = new System.Drawing.Size(27, 22);
            this.ArrowLBL.TabIndex = 0;
            this.ArrowLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NorthBTN
            // 
            this.NorthBTN.Location = new System.Drawing.Point(116, 253);
            this.NorthBTN.Name = "NorthBTN";
            this.NorthBTN.Size = new System.Drawing.Size(20, 20);
            this.NorthBTN.TabIndex = 1;
            this.NorthBTN.Text = "N";
            this.NorthBTN.UseVisualStyleBackColor = true;
            this.NorthBTN.Click += new System.EventHandler(this.northBTN_Click);
            // 
            // WestBTN
            // 
            this.WestBTN.Location = new System.Drawing.Point(90, 279);
            this.WestBTN.Name = "WestBTN";
            this.WestBTN.Size = new System.Drawing.Size(20, 20);
            this.WestBTN.TabIndex = 2;
            this.WestBTN.Text = "W";
            this.WestBTN.UseVisualStyleBackColor = true;
            this.WestBTN.Click += new System.EventHandler(this.westBTN_Click);
            // 
            // SouthBTN
            // 
            this.SouthBTN.Location = new System.Drawing.Point(116, 305);
            this.SouthBTN.Name = "SouthBTN";
            this.SouthBTN.Size = new System.Drawing.Size(20, 20);
            this.SouthBTN.TabIndex = 3;
            this.SouthBTN.Text = "S";
            this.SouthBTN.UseVisualStyleBackColor = true;
            this.SouthBTN.Click += new System.EventHandler(this.southBTN_Click);
            // 
            // EastBTN
            // 
            this.EastBTN.Location = new System.Drawing.Point(142, 279);
            this.EastBTN.Name = "EastBTN";
            this.EastBTN.Size = new System.Drawing.Size(20, 20);
            this.EastBTN.TabIndex = 4;
            this.EastBTN.Text = "E";
            this.EastBTN.UseVisualStyleBackColor = true;
            this.EastBTN.Click += new System.EventHandler(this.eastBTN_Click);
            // 
            // Move1
            // 
            this.Move1.Location = new System.Drawing.Point(26, 279);
            this.Move1.Name = "Move1";
            this.Move1.Size = new System.Drawing.Size(50, 20);
            this.Move1.TabIndex = 5;
            this.Move1.Text = "Go 1";
            this.Move1.UseVisualStyleBackColor = true;
            this.Move1.Click += new System.EventHandler(this.move1_Click);
            // 
            // Move10
            // 
            this.Move10.Location = new System.Drawing.Point(176, 279);
            this.Move10.Name = "Move10";
            this.Move10.Size = new System.Drawing.Size(50, 20);
            this.Move10.TabIndex = 6;
            this.Move10.Text = "Go 10";
            this.Move10.UseVisualStyleBackColor = true;
            this.Move10.Click += new System.EventHandler(this.move10_Click);
            // 
            // ArrowCoordsLBL
            // 
            this.ArrowCoordsLBL.AutoSize = true;
            this.ArrowCoordsLBL.Location = new System.Drawing.Point(23, 9);
            this.ArrowCoordsLBL.Name = "ArrowCoordsLBL";
            this.ArrowCoordsLBL.Size = new System.Drawing.Size(35, 13);
            this.ArrowCoordsLBL.TabIndex = 7;
            this.ArrowCoordsLBL.Text = "label2";
            // 
            // DisplayCoordsLBL
            // 
            this.DisplayCoordsLBL.AutoSize = true;
            this.DisplayCoordsLBL.Location = new System.Drawing.Point(127, 9);
            this.DisplayCoordsLBL.Name = "DisplayCoordsLBL";
            this.DisplayCoordsLBL.Size = new System.Drawing.Size(35, 13);
            this.DisplayCoordsLBL.TabIndex = 8;
            this.DisplayCoordsLBL.Text = "label3";
            // 
            // CounterLBL
            // 
            this.CounterLBL.AutoSize = true;
            this.CounterLBL.Location = new System.Drawing.Point(15, 319);
            this.CounterLBL.Name = "CounterLBL";
            this.CounterLBL.Size = new System.Drawing.Size(35, 13);
            this.CounterLBL.TabIndex = 9;
            this.CounterLBL.Text = "label4";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 334);
            this.Controls.Add(this.CounterLBL);
            this.Controls.Add(this.DisplayCoordsLBL);
            this.Controls.Add(this.ArrowCoordsLBL);
            this.Controls.Add(this.Move10);
            this.Controls.Add(this.Move1);
            this.Controls.Add(this.EastBTN);
            this.Controls.Add(this.SouthBTN);
            this.Controls.Add(this.WestBTN);
            this.Controls.Add(this.NorthBTN);
            this.Controls.Add(this.DisplayPanel);
            this.Name = "Main";
            this.Text = "Robot";
            this.DisplayPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DisplayPanel;
        private System.Windows.Forms.Label ArrowLBL;
        private System.Windows.Forms.Button NorthBTN;
        private System.Windows.Forms.Button WestBTN;
        private System.Windows.Forms.Button SouthBTN;
        private System.Windows.Forms.Button EastBTN;
        private System.Windows.Forms.Button Move1;
        private System.Windows.Forms.Button Move10;
        private System.Windows.Forms.Label ArrowCoordsLBL;
        private System.Windows.Forms.Label DisplayCoordsLBL;
        private System.Windows.Forms.Label CounterLBL;
    }
}

