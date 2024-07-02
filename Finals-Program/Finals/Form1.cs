﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Finals
{
    public partial class Form1 : Form


    {

        ContextMenuStrip emptystrip = new ContextMenuStrip(); 
        Random random = new Random();
        int randomNumber = 0;
        int turns = 0;
        int timeLeft = 120;

        public Form1()
        {
            InitializeComponent();
        }

        //For no character and right click menu plus backspace
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAnswer.ContextMenuStrip = emptystrip;
            timer1.Start();
            InitializeGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userInput = 0;



            //for empty textbox
            if (!(int.TryParse(txtAnswer.Text, out userInput)))
            {
                lblmessage.Text = "Enter any guess. Do not leave the textbox empty";
                return;
            }

            //no turns left
            if (turns == 0)
            {
                lblmessage.Text = "No turns left. \r\nTry Again next time.";
                txtAnswer.ReadOnly = true;
                bCheck.Enabled = false;
                cryGIF.Visible = true;
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Kate\Desktop\New folder\Finals\lose.wav");
                splayer.Play();
                return;
            }

            //for range control
            if (userInput < 1 || userInput > 100)
            {
                lblmessage.Text = "Enter number from 1-100 only";
                return;
            }

            //when less than right number
            if (userInput < randomNumber)
            {
                lblmessage.Text = "Your guess is lower than the right answer";
            }

            //when greater than right number
            if (userInput > randomNumber)
            {
                lblmessage.Text = "Your guess is higher than the right number";
            }

            //when equal to right number
            if (userInput == randomNumber)
            {
                txtAnswer.ReadOnly = true;
                bCheck.Enabled = false;
                lyliaGIF.Visible = false;
                congratsGIF.Visible = true;
                confettiGIF.Visible = true;
                cryGIF.Visible = false;
                lblWin.Visible = true;
                lblAgain.Visible = true;
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Kate\Desktop\New folder\Finals\win.wav");
                splayer.Play();
                timer1.Stop();
                lblShowtimeleft.Visible = true;
                lblShowtimeleft.Text = lblScoreval.Text;
                lblShow.Visible = true;
                lblScoreval.Visible = true;
                lblTimeleft.Visible = true;
            }

            turns -= 10;
            guessBar.Value = turns;
            

        }

        //Exiting the program
        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Play Again
        private void playAgainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timeLeft = 120;
            InitializeGame();
        }

        //Main game program
        private void InitializeGame()
        {
            randomNumber = random.Next(1, 101);
            turns = 100;
            guessBar.Value = 100;
            bCheck.Enabled = true;
            txtAnswer.ReadOnly = false;
            lblmessage.Text = "";
            txtAnswer.Text = "";
            lyliaGIF.Visible = true;
            confettiGIF.Visible = false;
            congratsGIF.Visible = false;
            cryGIF.Visible = false;
            lblWin.Visible = false;
            lblAgain.Visible = false;
            lblShowtimeleft.Visible = false;
            lblShow.Visible = false;
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Kate\Desktop\New folder\Finals\load.wav");
            splayer.PlayLooping();
        }

        //Timer stops when there is no time left and 10 attempts were used
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft - 1;
            lblScoreval.Text = Convert.ToString(timeLeft);
            if (timeLeft == 0)
            {
                timer1 = new Timer();
            }
            if (guessBar.Value == 0)
            {
                timer1.Stop();
            }

        }
    }
}