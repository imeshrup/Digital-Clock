namespace DigitalClock
{
    partial class DigitalClock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clock_lbl = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.redButton = new System.Windows.Forms.Button();
            this.orgButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.style_btn = new System.Windows.Forms.Button();
            this.style_btn2 = new System.Windows.Forms.Button();
            this.style_btn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clock_lbl
            // 
            this.clock_lbl.BackColor = System.Drawing.Color.Black;
            this.clock_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock_lbl.ForeColor = System.Drawing.Color.Red;
            this.clock_lbl.Location = new System.Drawing.Point(-2, -1);
            this.clock_lbl.Name = "clock_lbl";
            this.clock_lbl.Size = new System.Drawing.Size(905, 506);
            this.clock_lbl.TabIndex = 0;
            this.clock_lbl.Text = "Loading...";
            this.clock_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clock_lbl.Click += new System.EventHandler(this.clock_lbl_Click);
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.Location = new System.Drawing.Point(12, 518);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(27, 23);
            this.redButton.TabIndex = 1;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // orgButton
            // 
            this.orgButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orgButton.Location = new System.Drawing.Point(45, 518);
            this.orgButton.Name = "orgButton";
            this.orgButton.Size = new System.Drawing.Size(27, 23);
            this.orgButton.TabIndex = 2;
            this.orgButton.UseVisualStyleBackColor = false;
            this.orgButton.Click += new System.EventHandler(this.orgButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.Location = new System.Drawing.Point(78, 518);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(27, 23);
            this.yellowButton.TabIndex = 3;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.Location = new System.Drawing.Point(111, 518);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(27, 23);
            this.blueButton.TabIndex = 4;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greenButton.Location = new System.Drawing.Point(144, 518);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(27, 23);
            this.greenButton.TabIndex = 5;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // style_btn
            // 
            this.style_btn.BackColor = System.Drawing.Color.White;
            this.style_btn.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.style_btn.Location = new System.Drawing.Point(177, 518);
            this.style_btn.Name = "style_btn";
            this.style_btn.Size = new System.Drawing.Size(75, 23);
            this.style_btn.TabIndex = 6;
            this.style_btn.Text = "style_1";
            this.style_btn.UseVisualStyleBackColor = false;
            this.style_btn.Click += new System.EventHandler(this.style_btn_Click);
            // 
            // style_btn2
            // 
            this.style_btn2.BackColor = System.Drawing.Color.White;
            this.style_btn2.Font = new System.Drawing.Font("Magneto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.style_btn2.Location = new System.Drawing.Point(258, 518);
            this.style_btn2.Name = "style_btn2";
            this.style_btn2.Size = new System.Drawing.Size(75, 23);
            this.style_btn2.TabIndex = 7;
            this.style_btn2.Text = "style_2";
            this.style_btn2.UseVisualStyleBackColor = false;
            this.style_btn2.Click += new System.EventHandler(this.style_btn2_Click);
            // 
            // style_btn3
            // 
            this.style_btn3.BackColor = System.Drawing.Color.White;
            this.style_btn3.Font = new System.Drawing.Font("Wide Latin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.style_btn3.Location = new System.Drawing.Point(339, 518);
            this.style_btn3.Name = "style_btn3";
            this.style_btn3.Size = new System.Drawing.Size(84, 23);
            this.style_btn3.TabIndex = 8;
            this.style_btn3.Text = "style_3";
            this.style_btn3.UseVisualStyleBackColor = false;
            this.style_btn3.Click += new System.EventHandler(this.style_btn3_Click);
            // 
            // DigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(903, 553);
            this.Controls.Add(this.style_btn3);
            this.Controls.Add(this.style_btn2);
            this.Controls.Add(this.style_btn);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.orgButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.clock_lbl);
            this.Name = "DigitalClock";
            this.Text = "Digital Clock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label clock_lbl;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button orgButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button style_btn;
        private System.Windows.Forms.Button style_btn2;
        private System.Windows.Forms.Button style_btn3;
    }
}

