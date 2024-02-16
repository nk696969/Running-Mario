using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace RunningMario
{
    public partial class Form1 : Form
    {
        private SoundPlayer musicPlayer;
        private SoundPlayer spinPlayer;
        private bool isMusicPlaying = false;
        public Form1()
        {
            MessageBox.Show("to exit this software, must press M key\r\nto exit music, click Mario twice\r\n\r\nEmail: ", "Running Mario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);


            InitializeComponent();
            timer1.Interval = 100;
            timer1.Tick += timer1_Tick;
            timer1.Start();

            Stream strm1 = Properties.Resources.Music;
            musicPlayer = new SoundPlayer(strm1);
            musicPlayer.PlayLooping();

            Stream strm2 = Properties.Resources.Spin;
            spinPlayer = new SoundPlayer(strm2);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Location = new Point(Location.X - -10, Location.Y);

            if (Location.X > 1900)
            {
                Location = new Point(-200, Location.Y);
            }
            else
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isMusicPlaying)
            {
                musicPlayer.Stop();
                spinPlayer.Play();
                isMusicPlaying = false;
            }
            else
            {
                spinPlayer.PlaySync();
                musicPlayer.PlayLooping();
                isMusicPlaying = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)
            {
                MenuStarter m = new MenuStarter();
                m.Show();
            }
        }
    }
}
