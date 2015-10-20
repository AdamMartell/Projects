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
        public Player player1 = new Player(1);
        public Player player2 = new Player(2);
        ConnectionHandler connection = new ConnectionHandler();
        public Form1()
        {
            InitializeComponent();
            PlayerSetup();
            PositionControls();
            Environment.GenerateTerrain();
            PositionTanks();
        }
        public void PositionControls()
        {
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
            playGround.Bounds = Screen.PrimaryScreen.Bounds;
            player2.scoreBox.Location = new Point(playGround.Right - (player2.scoreBox.Width + 20), 10);
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
            player1.isTurn = true;
            player1.scoreBox = Player1ScoreBox;
            player2.scoreBox = Player2ScoreBox;
            player1.tank = Tank1;
            player2.tank = Tank2;
            player1.missile = missile;
            player2.missile = missile2;
        }

        private void FireButton_Click(object sender, EventArgs e)
        {
            if (player1.isTurn)
            {
                connection.Send("%" + ConvertPowerToX().ToString() + ConvertPowerToY().ToString());
                Action.FireMissile(ConvertPowerToX(), ConvertPowerToY(), player1, player2, this);
                player1.isTurn = false;
            }
            else
            {
                Action.FireMissile(ConvertPowerToX(), ConvertPowerToY(), player2, player1, this);
                player1.isTurn = true;
            }
        }
        private void PowerBar_Scroll(object sender, EventArgs e)
        {
            PowerBarDisplay.Clear();
            PowerBarDisplay.AppendText(PowerBar.Value.ToString());
        }

        public double ConvertPowerToX()
        {
            double x = ((Math.Cos(Convert.ToDouble(AngleBar.Value) * (Math.PI / 180.0))) * Convert.ToDouble(PowerBar.Value));
            x = Math.Round(x, 5);
            return x;
        }
        public double ConvertPowerToY()
        {
            double y = ((Math.Sin(Convert.ToDouble(AngleBar.Value) * (Math.PI / 180.0))) * Convert.ToDouble(PowerBar.Value));
            y = Math.Round(y, 5);
            return y;
        }

        private void AngleBar_Scroll(object sender, EventArgs e)
        {
            Angle.Clear();
            Angle.AppendText(AngleBar.Value.ToString() + "°");
        }
        public bool checkForCollision(PictureBox Tank, PictureBox missile)
        {
            bool collision;
            if ((missile.Right >= Tank.Left) && (missile.Bottom >= Tank.Top) && (missile.Left <= Tank.Right) && (missile.Top <= Tank.Bottom))
            {
                collision = true;
            }
            else
            {
                collision = false;
            }
            return collision;
        }

        private void MoveRightButton_Click(object sender, EventArgs e)
        {
            if (player1.isTurn)
            {
                Action.MoveTankRight(Tank1, missile);
            }
            else if (!player1.isTurn)
            {
                Action.MoveTankRight(Tank2, missile2);
            }
        }

        private void MoveLeftButton_Click(object sender, EventArgs e)
        {
            if (player1.isTurn)
            {
                Action.MoveTankLeft(Tank1, missile);
            }
            else if (!player1.isTurn)
            {
                Action.MoveTankLeft(Tank2, missile2);
            }
        }
    }
}