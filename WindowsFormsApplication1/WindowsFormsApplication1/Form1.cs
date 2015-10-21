using System;
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
    public partial class Form1 : Form
    {
        
        ConnectionHandler connection = new ConnectionHandler();
        public static Form1 UI;
        GameLogic game = new GameLogic();
        public Form1()
        {
            InitializeComponent();
            PlayerSetup();
            PositionControls();
            Environment.GenerateTerrain();
            PositionTanks();
            timer1.Enabled = true;
            UI = this;
        }
        public void PositionControls()
        {
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
            playGround.Bounds = Screen.PrimaryScreen.Bounds;
            GameLogic.player2.scoreBox.Location = new Point(playGround.Right - (GameLogic.player2.scoreBox.Width + 20), 10);
            PowerBar.Top = playGround.Bottom - (playGround.Bottom / 10);
            PowerBarDisplay.Top = playGround.Bottom - (playGround.Bottom / 10);
            FireButton.Top = playGround.Bottom - (playGround.Bottom / 10);
            AngleBar.Top = playGround.Bottom - (playGround.Bottom / 10);
            Angle.Top = playGround.Bottom - (playGround.Bottom / 10);
            MoveRightButton.Top = playGround.Bottom - (playGround.Bottom / 10);
            MoveLeftButton.Top = playGround.Bottom - (playGround.Bottom / 10);
        }
        public void PositionTanks()
        {
            Tank1.Location = new Point(Tank1.Right, Environment.TerrainSlices[Tank1.Right].Top - (Tank1.Bottom - Tank1.Top));
            Tank2.Location = new Point(Tank2.Right, Environment.TerrainSlices[Tank2.Right].Top - (Tank2.Bottom - Tank2.Top));
            missile.Location = new Point(Tank1.Left + ((Tank1.Right - Tank1.Left) / 2), Tank1.Top + ((Tank1.Bottom - Tank1.Top) / 2));
            missile2.Location = new Point(Tank2.Left + ((Tank2.Right - Tank2.Left) / 2), Tank2.Top + ((Tank2.Bottom - Tank2.Top) / 2));
        }
        public void PlayerSetup()
        {
            GameLogic.player1.isTurn = true;
            GameLogic.player1.scoreBox = Player1ScoreBox;
            GameLogic.player2.scoreBox = Player2ScoreBox;
            GameLogic.player1.tank = Tank1;
            GameLogic.player2.tank = Tank2;
            GameLogic.player1.missile = missile;
            GameLogic.player2.missile = missile2;
        }

        private void FireButton_Click(object sender, EventArgs e)
        {
            game.Run("fire");
        }
        private void PowerBar_Scroll(object sender, EventArgs e)
        {
            PowerBarDisplay.Clear();
            PowerBarDisplay.AppendText(PowerBar.Value.ToString());
        }
        private void AngleBar_Scroll(object sender, EventArgs e)
        {
            Angle.Clear();
            Angle.AppendText(AngleBar.Value.ToString() + "°");
        }
        private void MoveRightButton_Click(object sender, EventArgs e)
        {
            game.Run("moveright");
        }

        private void MoveLeftButton_Click(object sender, EventArgs e)
        {
            game.Run("moveleft");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            byte[] result;
            if (Program.commands.TryDequeue(out result))
            {
                Deserializer.GetData(result);
            }
        }

    }
}