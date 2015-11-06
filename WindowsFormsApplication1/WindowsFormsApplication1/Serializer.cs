using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Serializer
    {
        public static byte[] SerializeFire(int angle, int power, Player player)
        {
            int sentinel = 1;
            double serializedplayer = 0;
            double serializeddefender = 0;
            if (player == GameLogic.player1)
            {
                serializedplayer = 1;
                serializeddefender = 2;
            }
            else if (player == GameLogic.player2)
            {
                serializedplayer = 2;
                serializeddefender = 1;
            }
            byte[] data;
            data = new byte[] { Convert.ToByte(sentinel), Convert.ToByte(angle), Convert.ToByte(power), Convert.ToByte(serializedplayer), Convert.ToByte(serializeddefender) };
            return data;
        }
        public static byte[] SerializeMove(double sentinel, Player player)
        {
            double serializedplayer = 0;
            if (player == GameLogic.player1)
            {
                serializedplayer = 1;
            }
            else if (player == GameLogic.player2)
            {
                serializedplayer = 2;
            }
            byte[] data;
            data = new byte[] { (Convert.ToByte(sentinel)), Convert.ToByte(serializedplayer)};
            return data;
        }
    }
}
