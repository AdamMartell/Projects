using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Deserializer
    {
        public static void GetData(string data)
        {
            Form1 test = new Form1();
            if (data.StartsWith("%"))
            {
                Action.FireMissile(Convert.ToDouble(data.Substring(1, 6)), Convert.ToDouble(data.Substring(6, 6)), test.player1, test.player2, test);
            }
        }
    }
}
