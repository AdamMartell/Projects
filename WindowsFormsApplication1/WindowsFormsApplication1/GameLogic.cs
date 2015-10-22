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
        ConnectionHandler connection = new ConnectionHandler();
        //BFT TODO: This should be a list.
        //BFT TODO: These should NOT be static
        public static Player player1 = new Player(1);
        public static Player player2 = new Player(2);

        public void DoAction(string action)
        {
            switch (action)
            {
                case "fire":
                    if (player1.isTurn)
                    {
                        connection.Send(Serializer.SerializeFire(1, UI.AngleBar.Value, UI.PowerBar.Value, player1));
                        player1.isTurn = false;
                        Action.FireMissile(UI.AngleBar.Value, UI.PowerBar.Value, player1, player2);                        
                    }
                    else if (!player1.isTurn)
                    {
                        connection.Send(Serializer.SerializeFire(1, UI.AngleBar.Value, UI.PowerBar.Value, player2));
                        player1.isTurn = true;
                        Action.FireMissile(UI.AngleBar.Value, UI.PowerBar.Value, player2, player1);                        
                    }
                    break;
                case "moveright":
                    if (player1.isTurn)
                    {
                        connection.Send(Serializer.SerializeMove(3, player1));
                        Action.MoveTankRight(player1.tank, player1.missile);
                    }
                    else if (!player1.isTurn)
                    {
                        connection.Send(Serializer.SerializeMove(3, player2));
                        Action.MoveTankRight(player2.tank, player2.missile);
                    }
                    break;
                case "moveleft":
                    if (player1.isTurn)
                    {
                        connection.Send(Serializer.SerializeMove(2, player1));
                        Action.MoveTankLeft(player1.tank, player1.missile);
                    }
                    else if (!player1.isTurn)
                    {
                        connection.Send(Serializer.SerializeMove(2, player2));
                        Action.MoveTankLeft(player2.tank, player2.missile);
                    }
                    break;
            }
        }
    }
}
