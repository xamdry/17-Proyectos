using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pingPongGame
{
    public partial class gameForm : Form
    {

        public int speed_left = 4;
        public int speed_top = 4;
        public int points = 0;




        public gameForm()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            racket.Top = playGround.Bottom - (playGround.Bottom / 10);

            gameLbl.Left = (playGround.Width / 2) - (gameLbl.Width / 2);
            gameLbl.Top = (playGround.Height / 2) - (gameLbl.Height / 2);
            gameLbl.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);
            boll.Top += speed_top;
            boll.Left += speed_left;

            if (boll.Bottom >= racket.Top && boll.Bottom <= racket.Bottom && boll.Left >= racket.Left && boll.Right <= racket.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                points += 1;
                pointsLbl.Text = points.ToString();

                Random rand = new Random();
                playGround.BackColor = Color.FromArgb(rand.Next(150, 255), rand.Next(150, 255), rand.Next(150, 255));

            }
            if (boll.Left <= playGround.Left)
            {
                speed_left = -speed_left;
            }
            if (boll.Right >= playGround.Right)
            {
                speed_left = -speed_left;
            }
            if (boll.Top <= playGround.Top)
            {
                speed_top = -speed_top;
            }
            if (boll.Bottom >= playGround.Bottom)
            {
                timer1.Stop();
                gameLbl.Visible = true;
            }
        }

        private void gameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
            if (e.KeyCode == Keys.F1) //

            {
                boll.Top = 50;
                boll.Left = 50;
                speed_left = 4;
                speed_top = 4;
                pointsLbl.Text = "0";
                timer1.Enabled = true;
                gameLbl.Visible = false;
                playGround.BackColor = Color.White;
            }
        }
    }
}
