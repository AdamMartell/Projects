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
    class GameLogic
    {
        ConnectionHandler test = new ConnectionHandler();
        public static Player player1 = new Player(1);
        public static Player player2 = new Player(2);
        public void Run(string action)
        {
            switch (action)
            {
                case "fire":
                    if (player1.isTurn)
                    {
                        test.Send(Serialize.SerializeFire(1, ConvertPowerToX(), ConvertPowerToY(), player1, player2));
                        player1.isTurn = false;
                        Action.FireMissile(ConvertPowerToX(), ConvertPowerToY(), player1, player2);                        
                    }
                    else if (!player1.isTurn)
                    {
                        player1.isTurn = true;
                        Action.FireMissile(ConvertPowerToX(), ConvertPowerToY(), player2, player1);                        
                    }
                    break;
                case "moveright":
                    if (player1.isTurn)
                    {
                        Action.MoveTankRight(player1.tank, player1.missile);
                    }
                    else if (!player1.isTurn)
                    {
                        Action.MoveTankRight(player2.tank, player2.missile);
                    }
                    break;
                case "moveleft":
                    if (player1.isTurn)
                    {
                        Action.MoveTankLeft(player1.tank, player1.missile);
                    }
                    else if (!player1.isTurn)
                    {
                        Action.MoveTankLeft(player2.tank, player2.missile);
                    }
                    break;
            }
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
        public double ConvertPowerToX()
        {
            double x = ((Math.Cos(Convert.ToDouble(Form1.AngleBar.Value) * (Math.PI / 180.0))) * Convert.ToDouble(Form1.PowerBar.Value));
            x = Math.Round(x, 5);
            return x;
        }
        public double ConvertPowerToY()
        {
            double y = ((Math.Sin(Convert.ToDouble(Form1.AngleBar.Value) * (Math.PI / 180.0))) * Convert.ToDouble(Form1.PowerBar.Value));
            y = Math.Round(y, 5);
            return y;
        }
    }
}
