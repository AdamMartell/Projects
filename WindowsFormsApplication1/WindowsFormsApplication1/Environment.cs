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
        public static void GenerateTerrain()
        {
            TerrainSlices = new List<PictureBox>() { };
            //BFT TODO: Rename to be more descriptive (maybe combine rnd and rand?)
            Random rnd = new Random();
            Random rand = new Random();
            int high = 351;
            int low = 350;
            int chance = rand.Next(0, 10);
            for (int x = 0; x <= Form1.playGround.Right; x++)
            {
                if (x % 50 == 0)
                {
                    chance = rand.Next(0, 10);
                }
                int height = rnd.Next(low, high);
                TerrainSlices.Add(CreateTerrainSlice(height, x, x));
                if (chance >= 0 && chance < 2)
                {
                    high += 2;
                    low += 2;
                }

                if (chance >= 2 && chance < 4)
                {
                    high++;
                    low++;
                }
                else if (x >= 4 && x < 6)
                {
                    //BFT TODO: Remove sanity checks once you've confirmed that you are indeed sane
                    high = high;
                    low = low;
                }
                else if (chance > 6 && chance <= 8)
                {
                    high--;
                    low--;
                }
                else if (chance > 8 && chance <= 10)
                {
                    high -= 2;
                    low -= 2;
                }
            }
        }
        public static PictureBox CreateTerrainSlice(int height, int x, int y)
        {
            y = Form1.playGround.Bottom - height;
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
            Form1.playGround.Controls.Add(slice);
            return slice;
        }

    }
}
