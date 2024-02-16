using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RunningMario
{
    public partial class MenuStarter : Form
    {
        public MenuStarter()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Title: Running Mario\r\nMade: nk\r\nCode Lang: C#\r\nVer: Beta\r\n\r\nComment: Good luck <3","Info",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button2,MessageBoxOptions.ServiceNotification);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
