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

namespace destructable_terrain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
            playGround.Bounds = Screen.PrimaryScreen.Bounds;
            Random rnd = new Random();
            Random rand = new Random();
            int high = 401;
            int low = 400;
            int chance = rand.Next(0, 10);
            for (int x = 0; x <= playGround.Right; x++)
            {
                if (x % 50 == 0)
                {
                    chance = rand.Next(0, 10);
                }
                int height = rnd.Next(low, high);
                CreateTerrainSlice(height, x, x);
                if(chance >= 0 && chance < 2)
                {
                    high += 2;
                    low += 2;
                }

                if(chance >= 2 && chance < 4)
                {
                    high++;
                    low++;
                }
                else if (x >= 4 && x < 6)
                {
                    high = high;
                    low = low;
                }
                else if (chance > 6 && chance <= 8)
                {
                    high--;
                    low--;
                }
                else if (chance > 8 && chance <=10)
                {
                    high -= 2;
                    low -= 2;
                }
            }
        }
        public void CreateTerrainSlice(int height, int x, int y)
        {
            y = playGround.Bottom - height; 
            PictureBox test = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(1, 1),
                Location = new Point(x, y),
                Visible = true,
                BackColor = Color.Black
            };
            test.Height = height;
            test.BringToFront();
            playGround.Controls.Add(test);
        }
    }
}
