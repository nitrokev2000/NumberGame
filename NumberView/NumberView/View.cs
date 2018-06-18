using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberView
{
    public partial class View : Form
    {
        int pointx = 0;
        int pointy = 0;
        private string IP;
        CSharpSockets sockets;

        public View(string vIP)
        {
            this.IP = vIP;
            sockets = new CSharpSockets(IP);
            InitializeComponent();
        }

        private void btn_Brown_Click(object sender, EventArgs e)
        {
            pnl_Main.BackColor = Color.SandyBrown;
        }

        private void btn_Red_Click(object sender, EventArgs e)
        {
            pnl_Main.BackColor = Color.PaleVioletRed;
        }

        private void pnl_Paint_Paint(object sender, PaintEventArgs e)
        {
            Graphics grap = pnl_Paint.CreateGraphics();
            grap.DrawEllipse(System.Drawing.Pens.Red, pointx, pointy, 2, 2);
        }

        private void pnl_Paint_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pointx = e.X;
                pointy = e.Y;
                pnl_Paint_Paint(this, null);
            }
        }

        private void btn_Guess_Click(object sender, EventArgs e)
        {
            if (txt_Guess.Text == "")
            {
                txt_Guess.Text = "0";
            }
            sockets.SendData("Guess: " + txt_Guess.Text);
            if (sockets.GetRecieved() == 1)
            {
                lbl_Temp.Text = "Correct Number Has Reset";
            }
            else if (sockets.GetRecieved() == 2)
            {
                if (int.Parse(txt_Guess.Text) > 50000)
                {
                    txt_Guess.Text = "50000";
                    lbl_Temp.Text = "Out of Range - Lower";
                }
                else
                {
                    lbl_Temp.Text = "Lower";
                }
            }
            else if (sockets.GetRecieved() == 3)
            {
                lbl_Temp.Text = "Higher";
            }
        }

        private void btn_Retry_Click(object sender, EventArgs e)
        {
            sockets.SendData("Reset");
        }

        public void SetIP(string vIP)
        {
            this.IP = vIP;
        }
    }
}
