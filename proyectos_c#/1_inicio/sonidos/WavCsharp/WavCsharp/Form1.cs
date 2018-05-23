using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WavCsharp
{
    public partial class Form1 : Form
    {
        // This SoundPlayer plays a sound whenever the player hits a wall.
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\chord.wav");

        // This SoundPlayer plays a sound when the player finishes the game.
        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\tada.wav");


        public Form1()
        {
            InitializeComponent();
        }
        private void MoveToStart()
        {
            this.startSoundPlayer.Play();
            //this.finishSoundPlayer.Play();
            
            MessageBox.Show("Congratulations!");
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MoveToStart();
        }
    }
}
