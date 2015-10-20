﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Player
    {
        public bool isTurn;
        public int score;
        public int playerNumber;
        public RichTextBox scoreBox;
        public PictureBox tank;
        public PictureBox missile;
        public Player(int playerNumber)
        {
            isTurn = false;
            score = 0;
            this.playerNumber = playerNumber;
        }
        public void AddPoint()
        {
            score += 1;
            //BFT TODO: This code belongs in a different class that handles when the game is over, and the UI portion belongs in a different place altogether
            if (score >= 3)
            {
                Form1.WinBox.Text = "Player " + playerNumber.ToString() + " WINS!!!!!";
                Form1.WinBox.Show();
            }
            scoreBox.Clear();
            scoreBox.AppendText(score.ToString());
        }
    }
}