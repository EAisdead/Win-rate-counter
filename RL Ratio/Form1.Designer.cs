namespace RL_Ratio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnL = new System.Windows.Forms.Button();
            this.lblWins = new System.Windows.Forms.Label();
            this.btnW = new System.Windows.Forms.Button();
            this.lblLosses = new System.Windows.Forms.Label();
            this.lblWinRate = new System.Windows.Forms.Label();
            this.btnDecreaseW = new System.Windows.Forms.Button();
            this.btnDecreaseL = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.SteelBlue;
            this.btnL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnL.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnL.FlatAppearance.BorderSize = 3;
            this.btnL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this.btnL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnL.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnL.Location = new System.Drawing.Point(633, 296);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(75, 75);
            this.btnL.TabIndex = 2;
            this.btnL.TabStop = false;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWins.Location = new System.Drawing.Point(73, 115);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(45, 54);
            this.lblWins.TabIndex = 0;
            this.lblWins.Text = "0";
            this.lblWins.Click += new System.EventHandler(this.lblWins_Click);
            // 
            // btnW
            // 
            this.btnW.BackColor = System.Drawing.Color.Firebrick;
            this.btnW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnW.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnW.FlatAppearance.BorderSize = 3;
            this.btnW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnW.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnW.Location = new System.Drawing.Point(84, 296);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(75, 75);
            this.btnW.TabIndex = 1;
            this.btnW.TabStop = false;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = false;
            this.btnW.Click += new System.EventHandler(this.btnW_Click);
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLosses.Location = new System.Drawing.Point(81, 115);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(45, 54);
            this.lblLosses.TabIndex = 0;
            this.lblLosses.Text = "0";
            this.lblLosses.Click += new System.EventHandler(this.lblLosses_Click);
            // 
            // lblWinRate
            // 
            this.lblWinRate.AutoSize = true;
            this.lblWinRate.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWinRate.Location = new System.Drawing.Point(355, 137);
            this.lblWinRate.Name = "lblWinRate";
            this.lblWinRate.Size = new System.Drawing.Size(90, 62);
            this.lblWinRate.TabIndex = 0;
            this.lblWinRate.Text = "0%";
            this.lblWinRate.Click += new System.EventHandler(this.lblWinRate_Click);
            // 
            // btnDecreaseW
            // 
            this.btnDecreaseW.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDecreaseW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecreaseW.Enabled = false;
            this.btnDecreaseW.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDecreaseW.FlatAppearance.BorderSize = 2;
            this.btnDecreaseW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDecreaseW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this.btnDecreaseW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecreaseW.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDecreaseW.Location = new System.Drawing.Point(164, 379);
            this.btnDecreaseW.Name = "btnDecreaseW";
            this.btnDecreaseW.Size = new System.Drawing.Size(61, 25);
            this.btnDecreaseW.TabIndex = 3;
            this.btnDecreaseW.TabStop = false;
            this.btnDecreaseW.Text = "-1";
            this.btnDecreaseW.UseVisualStyleBackColor = false;
            this.btnDecreaseW.Click += new System.EventHandler(this.btnDecreaseW_Click);
            // 
            // btnDecreaseL
            // 
            this.btnDecreaseL.BackColor = System.Drawing.Color.Firebrick;
            this.btnDecreaseL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecreaseL.Enabled = false;
            this.btnDecreaseL.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDecreaseL.FlatAppearance.BorderSize = 2;
            this.btnDecreaseL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnDecreaseL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnDecreaseL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecreaseL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDecreaseL.Location = new System.Drawing.Point(561, 379);
            this.btnDecreaseL.Name = "btnDecreaseL";
            this.btnDecreaseL.Size = new System.Drawing.Size(61, 25);
            this.btnDecreaseL.TabIndex = 4;
            this.btnDecreaseL.TabStop = false;
            this.btnDecreaseL.Text = "-1";
            this.btnDecreaseL.UseVisualStyleBackColor = false;
            this.btnDecreaseL.Click += new System.EventHandler(this.btnDecreaseL_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblWins);
            this.groupBox1.Location = new System.Drawing.Point(13, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wins:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblLosses);
            this.groupBox2.Location = new System.Drawing.Point(561, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 212);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(51, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Losses:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SlateGray;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.lblWinRate);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 262);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(312, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Win Rate:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(356, 379);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 25);
            this.btnReset.TabIndex = 5;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnDecreaseL);
            this.Controls.Add(this.btnDecreaseW);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnL);
            this.Name = "Form1";
            this.Text = "RL W/L Ratio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnL;
        private Label lblWins;
        private Button btnW;
        private Label lblLosses;
        private Label lblWinRate;
        private Button btnDecreaseW;
        private Button btnDecreaseL;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnReset;
        private Label label1;
        private Label label2;
        private Label label3;

        
    }
}