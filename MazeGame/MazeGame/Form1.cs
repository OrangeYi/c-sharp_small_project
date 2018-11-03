using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer startSound = new System.Media.SoundPlayer(@"C:\Windows\media\Alarm10.wav");
        System.Media.SoundPlayer endSound = new System.Media.SoundPlayer(@"C:\Windows\media\Alarm01.wav");
        public Form1()
        {
            InitializeComponent();
            movetostart();
        }

        private void finishLabel_MouseEnter(object sender, EventArgs e)
        {
            endSound.Play();
            MessageBox.Show("YES! YOU DID IT!");
            Close();
        }

        private void movetostart()
        {
            startSound.Play();
            Point beginpoint = panel1.Location;
            beginpoint.Offset(10, 10);
            //cursor positong = current mouse position
            //pointtoscreen = to get the position in out app realative to our screen
            Cursor.Position = PointToScreen(beginpoint);
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            movetostart();
        }
    }
}
