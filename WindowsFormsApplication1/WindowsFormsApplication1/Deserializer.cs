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
            Player attacker;
            Player defender;
            double sentinel =  data[0];
            if(data[3] == 1)
            {
                attacker = GameLogic.player1;
                defender = GameLogic.player2;
            }
            else
            {
                attacker = GameLogic.player2;
                defender = GameLogic.player1;
            }
            if (sentinel == 1)
            {
                Action.FireMissile(data[1], data[2], attacker, defender);
            }
        }
    }
}
