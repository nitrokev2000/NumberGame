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
    public partial class IpAddress : Form
    {
        public IpAddress()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            View view = new View(txt_IP.Text);
            view.Show();
        }
    }
}
