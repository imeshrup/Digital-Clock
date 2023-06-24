using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();
            redButton.FlatStyle = FlatStyle.Flat;
            orgButton.FlatStyle = FlatStyle.Flat;
            yellowButton.FlatStyle = FlatStyle.Flat;
            blueButton.FlatStyle = FlatStyle.Flat;
            greenButton.FlatStyle = FlatStyle.Flat;
        }

        private void clock_lbl_Click(object sender, EventArgs e)
        {
            clockTimer.Start();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            clock_lbl.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            clock_lbl.ForeColor = Color.Green;
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            clock_lbl.ForeColor = Color.Blue;
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            clock_lbl.ForeColor = Color.Yellow;
        }

        private void orgButton_Click(object sender, EventArgs e)
        {
            clock_lbl.ForeColor = Color.Orange;
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            clock_lbl.ForeColor = Color.Red;
        }

        private void style_btn_Click(object sender, EventArgs e)
        {
            clock_lbl.Font = new Font("Impact", 90, FontStyle.Regular);
        }

        private void style_btn2_Click(object sender, EventArgs e)
        {
            clock_lbl.Font = new Font("Magneto", 90, FontStyle.Regular);
        }

        private void style_btn3_Click(object sender, EventArgs e)
        {
            clock_lbl.Font = new Font("Latin", 90, FontStyle.Regular);
        }
    }
}
