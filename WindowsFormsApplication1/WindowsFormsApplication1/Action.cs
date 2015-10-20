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
    static class Action
    {
        //BFT TODO: parameter variables have first letter lowercase
        public static void MoveTankRight(PictureBox Tank, PictureBox missile)
        {
            //BFT TODO: Get rid of tankX, tankY; address position weirdness in this function
            int tankX = Tank.Location.X;
            int TankY = Tank.Location.Y;
            int missileX;
            int missileY;
            for (int i = 0; i < 15; i += 1)
            {
                tankX += i;
                Point z = new Point(tankX, Environment.TerrainSlices[Tank.Right - ((Tank.Right - Tank.Left) / 2)].Top - (Tank.Bottom - Tank.Top));
                Tank.Location = z;
                //BFT TODO: Hide missile when it's not supposed to display (don't move it along with the tank)
                missileX = Tank.Left + ((Tank.Right - Tank.Left) / 2);
                missileY = Tank.Top + ((Tank.Bottom - Tank.Top) / 2);
                Point c = new Point(missileX, missileY);
                missile.Location = c;
                Thread.Sleep(50);
            }
        }


        //BFT TODO: Same comments as above
        public static void MoveTankLeft(PictureBox Tank, PictureBox missile)
        {
            int tankX = Tank.Location.X;
            int TankY = Tank.Location.Y;
            int missileX;
            int missileY;
            for (int i = 0; i < 15; i += 1)
            {
                tankX -= i;
                Point z = new Point(tankX, Environment.TerrainSlices[Tank.Right - ((Tank.Right - Tank.Left) / 2)].Top - (Tank.Bottom - Tank.Top));
                Tank.Location = z;
                missileX = Tank.Left + ((Tank.Right - Tank.Left) / 2);
                missileY = Tank.Top + ((Tank.Bottom - Tank.Top) / 2);
                Point c = new Point(missileX, missileY);
                missile.Location = c;
                Thread.Sleep(50);
            }
        }
        public static void FireMissile(double Vx, double Vy, Player player, Player defender, Form1 test)
        {
            //BFT TODO: Get rid of missileX, missileY; address position weirdness in this function
            int missileX = player.tank.Left + ((player.tank.Right - player.tank.Left) / 2);
            int missileY = player.tank.Top + ((player.tank.Bottom - player.tank.Top) / 2);
            player.missile.Location = new Point(missileX, missileY);
            player.missile.Visible = true;
            //BFT TODO: change (Vx, Vy) to Point velocity
            for (double i = 0; i < 10; i += 0.05)
            {
                if (!test.checkForCollision(defender.tank, player.missile))
                {
                    player.missile.Location = new Point(missileX, missileY);
                    missileX = Convert.ToInt32(missileX + (Vx * i));
                    //BFT TODO: 4.9 is a magic number
                    missileY = Convert.ToInt32(missileY - ((Vy * i) - (4.9 * (i * i))));
                    //BFT TODO: Get rid of this
                    Thread.Sleep(20);
                }
            }
            if (test.checkForCollision(defender.tank, player.missile))
            {
                player.AddPoint();
            }
            missileX = player.tank.Left + ((player.tank.Right - player.tank.Left) / 2);
            missileY = player.tank.Top + ((player.tank.Bottom - player.tank.Top) / 2);
            player.missile.Location = new Point(missileX, missileY);
        }
    }
}
