using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Likanica5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int X0 = 600;
        public int XX = 600;
        public int Y0 = 500;
        Random R = new Random();

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Button newbutton = new Button();
                newbutton.Parent = this;
                newbutton.Location = new Point(X0, Y0);
                newbutton.FlatAppearance.BorderSize = 0;
                newbutton.FlatStyle = FlatStyle.Flat;
                newbutton.BackColor = Color.FromArgb(R.Next(0,255), R.Next(0, 255), R.Next(0, 255));
                newbutton.Size = new Size(50, 50);
                X0 = X0 + 10;
                Y0 = Y0 - 10;
            }
            if (X0 >= 600)
            {
                XX -= 10;
                X0 = XX;
                Y0 = 500;
            }
        }
            private void Form1_Load(object sender, EventArgs e)
            {

            }
    }
}
