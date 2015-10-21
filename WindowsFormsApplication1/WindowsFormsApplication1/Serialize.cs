using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Serialize
    {
        public static byte[] SerializeFire(double sentinel, double xpower, double ypower, Player player, Player defender)
        {
            double splayer = 0;
            double sdefender = 0;
            if (player == GameLogic.player1)
            {
                splayer = 1;
                sdefender = 2;
            }
            else if (player == GameLogic.player2)
            {
                splayer = 2;
                sdefender = 1;
            }
            byte[] data;
            data = new byte[] { (Convert.ToByte(sentinel)), Convert.ToByte(xpower), Convert.ToByte(ypower), Convert.ToByte(splayer), Convert.ToByte(sdefender) };
            return data;
        }
    }
}
