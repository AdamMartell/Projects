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
        const double GRAVITY = 9.81;
        public static void MoveTankRight(PictureBox tank, PictureBox missile)
        {
            int missileX;
            int missileY;
            for (int i = 0; i < 15; i += 1)
            {
                tank.Location = new Point(tank.Location.X + i, Environment.TerrainSlices[tank.Right - ((tank.Right - tank.Left) / 2)].Top - (tank.Bottom - tank.Top));
                //BFT TODO: Hide missile when it's not supposed to display (don't move it along with the tank)
                missileX = tank.Left + ((tank.Right - tank.Left) / 2);
                missileY = tank.Top + ((tank.Bottom - tank.Top) / 2);
                missile.Location = new Point(missileX, missileY);
                Thread.Sleep(50);
            }
        }
        public static void MoveTankLeft(PictureBox tank, PictureBox missile)
        {
            int missileX;
            int missileY;
            for (int i = 0; i < 15; i += 1)
            {
                tank.Location = new Point(tank.Location.X - i, Environment.TerrainSlices[tank.Right - ((tank.Right - tank.Left) / 2)].Top - (tank.Bottom - tank.Top));
                missileX = tank.Left + ((tank.Right - tank.Left) / 2);
                missileY = tank.Top + ((tank.Bottom - tank.Top) / 2);
                missile.Location = new Point(missileX, missileY);
                Thread.Sleep(50);
            }
        }

        public static void FireMissile(int angle, int power, Player player, Player defender)
        {
            double Vx = ConvertPowerToX(angle, power);
            double Vy = ConvertPowerToY(angle, power);
            for (double i = 0; i < 10; i += 0.05)
            {
                if (!checkForCollision(defender.tank, player.missile) && !checkForEnvironmentCollision(player.missile))
                {
                    player.missile.Location = new Point(Convert.ToInt32(player.missile.Location.X + (Vx * i)), Convert.ToInt32(player.missile.Location.Y - ((Vy * i) - ((GRAVITY/2) * (i * i)))));
                    //BFT TODO: Get rid of this
                    Thread.Sleep(20);
                }
            }
            //Explosion(player.missile);
            if (checkForCollision(defender.tank, player.missile))
            {
                player.AddPoint();
            }
            player.missile.Location = new Point(player.tank.Left + ((player.tank.Right - player.tank.Left) / 4), player.tank.Top + ((player.tank.Bottom - player.tank.Top) / 4));
        }
        public static bool checkForCollision(PictureBox Tank, PictureBox missile)
        {
            return ((missile.Right >= Tank.Left) && (missile.Bottom >= Tank.Top) && (missile.Left <= Tank.Right) && (missile.Top <= Tank.Bottom));
        }
        public static double ConvertPowerToX(int angle, int power)
        {
            double x = ((Math.Cos(Convert.ToDouble(angle) * (Math.PI / 180.0))) * Convert.ToDouble(power));
            return x;
        }
        public static double ConvertPowerToY(int angle, int power)
        {
            double y = ((Math.Sin(Convert.ToDouble(angle) * (Math.PI / 180.0))) * Convert.ToDouble(power));
            return y;
        }
        public static bool checkForEnvironmentCollision(PictureBox missile)
        {
            try
            {
                return (missile.Bottom >= Environment.TerrainSlices[missile.Location.X].Top);
            }
            catch (Exception e)
            {
                return true;
            }
        }
        public static void Explosion(PictureBox missile)
        {
            string currentImage = missile.ImageLocation;
            for (int x = 0; x < 10; x++)
            {
                missile.ImageLocation = @"C:\Users\amartell_be\Downloads\topdowntanks\PNG\Smoke\smokeGrey0.png";
                missile.Refresh();
                Thread.Sleep(80);
                missile.ImageLocation = @"C:\Users\amartell_be\Downloads\topdowntanks\PNG\Smoke\smokeGrey1.png";
                missile.Refresh();
                Thread.Sleep(80);
                missile.ImageLocation = @"C:\Users\amartell_be\Downloads\topdowntanks\PNG\Smoke\smokeGrey2.png";
                missile.Refresh();
                Thread.Sleep(80);
                missile.ImageLocation = @"C:\Users\amartell_be\Downloads\topdowntanks\PNG\Smoke\smokeGrey3.png";
                missile.Refresh();
                Thread.Sleep(80);
                missile.ImageLocation = @"C:\Users\amartell_be\Downloads\topdowntanks\PNG\Smoke\smokeGrey4.png";
                missile.Refresh();
                Thread.Sleep(80);
                missile.ImageLocation = @"C:\Users\amartell_be\Downloads\topdowntanks\PNG\Smoke\smokeGrey5.png";
                missile.Refresh();
                Thread.Sleep(80);
            }
            missile.ImageLocation = currentImage;
        }
    }
}
