using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace rpg_game_wf
{
    public partial class Form3 : Form
    {
        private List<PictureBox> pictures = new List<PictureBox>();
        public Form3()
        {
            InitializeComponent();
            timer1.Interval = 1;
            timer1.Start();

            timer2.Interval = 1000;
            timer2.Start();

            timer3.Interval = 10;
            timer3.Start();

            timer4.Interval = 1;
            timer4.Start();

            timer5.Interval = 1;
            timer5.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            this.Controls.Remove(picture);
            pictures.Remove(picture);
            StoreInfo.score += 1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {



        }

        private void timer3_Tick(object sender, EventArgs e)
        {
        }

        private void timer4_Tick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {


        }

        private void timer5_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            Random rand = new Random();

            PictureBox picture = new PictureBox();
            picture.Location = new Point(rand.Next(0, 500), 300);
            picture.Size = new Size(25, 22);

            picture.Image = Properties.Resources.star;

            picture.BackColor = Color.Transparent;
            picture.Click += pictureBox1_Click;

            pictures.Add(picture);
            this.Controls.Add(picture);
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {

            int speed = 2;

            foreach (var pic in pictures)
            {
                Point point = Point.Add(pic.Location, new Size(0, -speed));
                pic.Location = point;
            }
        }

        private void timer4_Tick_1(object sender, EventArgs e)
        {
            for (int i = pictures.Count - 1; i >= 0; i--)
            {
                var pic = pictures[i];
                if (pic.Location.Y <= 0)
                {
                    this.Controls.Remove(pic);
                    pictures.RemoveAt(i);
                    StoreInfo.counter += 1;
                }
            }
            if (StoreInfo.score == 3  || StoreInfo.counter == 3)
            {
                this.Close();
            }
            else if(StoreInfo.score == 1 && StoreInfo.counter == 2)
            {
                this.Close();
            }
            else if(StoreInfo.score == 2 && StoreInfo.counter == 1)
            {
                this.Close();
            }
          
        }

        private void timer5_Tick_1(object sender, EventArgs e)
        {

        }
    }
}
