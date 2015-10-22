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
    class Environment
    {
        public static List<PictureBox> TerrainSlices;
        public static void GenerateTerrain(List<int> sliceHeights)
        {
            int x = 0;
            TerrainSlices = new List<PictureBox>() { };
            foreach (int height in sliceHeights)
            {
                TerrainSlices.Add(CreateTerrainSlice(height, x, x));
                x++;
            }
            //Random randomChance = new Random();
            //int height = 351;
            //int chance = randomChance.Next(0, 10);
            //for (int x = 0; x <= UI.playGround.Right; x++)
            //{
            //    if (x % 50 == 0)
            //    {
            //        chance = randomChance.Next(0, 10);
            //    }
            //    TerrainSlices.Add(CreateTerrainSlice(height, x, x));
            //    if (chance >= 0 && chance < 2)
            //    {
            //        height += 2;
            //    }

            //    if (chance >= 2 && chance < 4)
            //    {
            //        height++;
            //    }
            //    else if (chance > 6 && chance <= 8)
            //    {
            //        height--;
            //    }
            //    else if (chance > 8 && chance <= 10)
            //    {
            //        height -= 2;
            //    }
            //}
        }
        public static PictureBox CreateTerrainSlice(int height, int x, int y)
        {
            y = UI.playGround.Bottom - height;
            PictureBox slice = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(1, 1),
                Location = new Point(x, y),
                Visible = true,
                BackColor = Color.Black
            };
            slice.Height = height;
            slice.BringToFront();
            UI.playGround.Controls.Add(slice);
            return slice;
        }

    }
}
