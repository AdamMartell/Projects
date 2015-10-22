using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Deserializer
    {
        
        public static void GetData(byte[] data)
        {
            //BFT TODO: This needs to be cleaned up.
            double sentinel = data[0];
            if (sentinel == 1)
            {
                int angle = data[1];
                int power = data[2];
                Player attacker;
                Player defender;
                if(data[3] == 1)
                {
                    attacker = GameLogic.player1;
                    defender = GameLogic.player2;
                    GameLogic.player1.isTurn = false;
                }
                else
                {
                    attacker = GameLogic.player2;
                    defender = GameLogic.player1;
                    GameLogic.player1.isTurn = true;
                }
            
                Action.FireMissile(angle, power, attacker, defender);
            }
            else if (sentinel == 2)
            {
                Player player;
                if (data[1] == 1)
                {
                    player = GameLogic.player1;
                }
                else
                {
                    player = GameLogic.player2;
                }
                Action.MoveTankLeft(player.tank, player.missile);
            }
            else if (sentinel == 3)
            {
                Player player;
                if (data[1] == 1)
                {
                    player = GameLogic.player1;
                }
                else
                {
                    player = GameLogic.player2;
                }
                Action.MoveTankRight(player.tank, player.missile);
            }
        }
    }
}
