using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursTP
{
    public partial class Form1 : Form
    {
        EMM emm ;
        TP tel ;
        public Form1()
        {
            InitializeComponent();
            picDisplay.MouseWheel += picDisplay_MouseWheel;
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            emm = new EMM{TPP = 0,RAZ = 10,SMIN = 10,SMAX = 10,TP1 = Color.Blue,TP2 = Color.FromArgb(0, Color.Purple),VALUE1 = 50,VALUE2 = 500,X = 150,Y = 100,};

            tel = new TP{X = picDisplay.Width / 2 + 100,Y = picDisplay.Height / 2,OX = 100,OY = 100,};
            emm.tel = tel;

        }
        private void timer_tick1(object sender, EventArgs e)
        {
            emm.UpdateState();
            var g = Graphics.FromImage(picDisplay.Image);
            var f = colorDialog1.Color;
            g.Clear(f);

            emm.Render(g);

            picDisplay.Invalidate();
        }
        private void picDisplay_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0 && tel.Rad > 5)
            {
                tel.Rad -= 5;
            }
            else if (e.Delta > 0 && tel.Rad < 300)
            {
                tel.Rad += 5;
            }

        }
        private void trackBar3TP_Scroll(object sender, EventArgs e)
        {
            tel.OTP = trackBar3TP.Value;
        }

        private void trackBar1Speed_Scroll(object sender, EventArgs e)
        {
            tel.OS = trackBar1Speed.Value;
        }

        private void trackBar2Value_Scroll(object sender, EventArgs e)
        {
            emm.VALUE1 = trackBar2Value.Value;
        }

        private void picDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            string button = e.Button.ToString();
            if (button == "Left")
            {
                tel.X = e.X;
                tel.Y = e.Y;
            }
            else if (button == "Right")
            {
                tel.OX = e.X;
                tel.OY = e.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
            }
        }
    }
}
