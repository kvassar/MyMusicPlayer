using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            MediaPlayer.Ctlcontrols.stop();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
            MediaPlayer.URL = textBox1.Text;
        }

        private void Play_Click(object sender, EventArgs e)
        {
            MediaPlayer.Ctlcontrols.play();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            MediaPlayer.Ctlcontrols.pause();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
