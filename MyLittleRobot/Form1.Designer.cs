namespace MyLittleRobot {
    partial class Form1 {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.northBTN = new System.Windows.Forms.Button();
            this.westBTN = new System.Windows.Forms.Button();
            this.southBTN = new System.Windows.Forms.Button();
            this.eastBTN = new System.Windows.Forms.Button();
            this.move1 = new System.Windows.Forms.Button();
            this.move10 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 200);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.Location = new System.Drawing.Point(80, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 0;
            // 
            // northBTN
            // 
            this.northBTN.Location = new System.Drawing.Point(116, 246);
            this.northBTN.Name = "northBTN";
            this.northBTN.Size = new System.Drawing.Size(20, 20);
            this.northBTN.TabIndex = 1;
            this.northBTN.Text = "N";
            this.northBTN.UseVisualStyleBackColor = true;
            this.northBTN.Click += new System.EventHandler(this.northBTN_Click);
            // 
            // westBTN
            // 
            this.westBTN.Location = new System.Drawing.Point(90, 272);
            this.westBTN.Name = "westBTN";
            this.westBTN.Size = new System.Drawing.Size(20, 20);
            this.westBTN.TabIndex = 2;
            this.westBTN.Text = "W";
            this.westBTN.UseVisualStyleBackColor = true;
            this.westBTN.Click += new System.EventHandler(this.westBTN_Click);
            // 
            // southBTN
            // 
            this.southBTN.Location = new System.Drawing.Point(116, 298);
            this.southBTN.Name = "southBTN";
            this.southBTN.Size = new System.Drawing.Size(20, 20);
            this.southBTN.TabIndex = 3;
            this.southBTN.Text = "S";
            this.southBTN.UseVisualStyleBackColor = true;
            this.southBTN.Click += new System.EventHandler(this.southBTN_Click);
            // 
            // eastBTN
            // 
            this.eastBTN.Location = new System.Drawing.Point(142, 272);
            this.eastBTN.Name = "eastBTN";
            this.eastBTN.Size = new System.Drawing.Size(20, 20);
            this.eastBTN.TabIndex = 4;
            this.eastBTN.Text = "E";
            this.eastBTN.UseVisualStyleBackColor = true;
            this.eastBTN.Click += new System.EventHandler(this.eastBTN_Click);
            // 
            // move1
            // 
            this.move1.Location = new System.Drawing.Point(26, 272);
            this.move1.Name = "move1";
            this.move1.Size = new System.Drawing.Size(50, 20);
            this.move1.TabIndex = 5;
            this.move1.Text = "Go 1";
            this.move1.UseVisualStyleBackColor = true;
            this.move1.Click += new System.EventHandler(this.move1_Click);
            // 
            // move10
            // 
            this.move10.Location = new System.Drawing.Point(176, 272);
            this.move10.Name = "move10";
            this.move10.Size = new System.Drawing.Size(50, 20);
            this.move10.TabIndex = 6;
            this.move10.Text = "Go 10";
            this.move10.UseVisualStyleBackColor = true;
            this.move10.Click += new System.EventHandler(this.move10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 334);
            this.Controls.Add(this.move10);
            this.Controls.Add(this.move1);
            this.Controls.Add(this.eastBTN);
            this.Controls.Add(this.southBTN);
            this.Controls.Add(this.westBTN);
            this.Controls.Add(this.northBTN);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Robot";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button northBTN;
        private System.Windows.Forms.Button westBTN;
        private System.Windows.Forms.Button southBTN;
        private System.Windows.Forms.Button eastBTN;
        private System.Windows.Forms.Button move1;
        private System.Windows.Forms.Button move10;
    }
}

