using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    public partial class Form1: Form
    {

        private Point pos;
        private bool moving, menu = false;
        private int cntcoins = 0;

        public Form1()
        {
            InitializeComponent();

            bg1.MouseDown += MouseClickDown;
            bg1.MouseUp += MouseClickUp;
            bg1.MouseMove += MouseClickMove;
            bg2.MouseDown += MouseClickDown;
            bg2.MouseUp += MouseClickUp;
            bg2.MouseMove += MouseClickMove;

            lose.Visible = false;
            button.Visible = false;
            KeyPreview = true;

        }
        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            moving = true;
            pos.X = e.X;
            pos.Y = e.Y + bg1.Top;
        }

        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            moving = false;
        }


        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if (moving) 
            {
                Point currentPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(currentPoint.X - pos.X, currentPoint.Y - pos.Y + bg1.Top);
            }
        }


        

       
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int speed = 5;
            bg1.Top += speed;
            bg2.Top += speed;

            coin.Top += speed;

            Random randm = new Random();
            enemy1.Top += randm.Next(6, 9);
            enemy2.Top += randm.Next(6, 9);
            enemy3.Top += randm.Next(6, 9);

            if (bg1.Top >= 650)
            {
                bg1.Top = 0;
                bg2.Top = -650;
            }

            if (coin.Top >= 650)
            {
                coin.Top = -100;
                Random rand = new Random();
                coin.Left = rand.Next(155, 650);
            }

            if (enemy1.Top >= 650) 
            { 
                enemy1.Top = -1000;
                Random rand = new Random();
                enemy1.Left = rand.Next(145, 220);
            }

            if (enemy2.Top >= 650)
            {
                enemy2.Top = -200;
                Random rand = new Random();
                enemy2.Left = rand.Next(340, 425);
            }

            if (enemy3.Top >= 650)
            {
                enemy3.Top = -250;
                Random rand = new Random();
                enemy3.Left = rand.Next(520, 610);
            }

            if (car.Bounds.IntersectsWith(enemy1.Bounds) || car.Bounds.IntersectsWith(enemy2.Bounds) || car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer.Enabled = false;
                lose.Visible = true;
                button.Visible = true;
                menu = true;
            }

            if (car.Bounds.IntersectsWith(coin.Bounds))
            {
                cntcoins++;
                coinlbl.Text = "Coins: " + cntcoins.ToString();
                coin.Top = -100;
                Random rand = new Random();
                coin.Left = rand.Next(155, 650);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(menu) return;

            int speed = 15;
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && car.Left > 145)
                car.Left -= speed;
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && car.Right < 700)
                car.Left += speed;
            else if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W) && car.Top > 350)
                car.Top -= speed;
            else if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.S) && car.Top < 500)
                car.Top += speed;
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            enemy1.Top = -450;
            enemy2.Top = -200;
            enemy3.Top = -250;
            lose.Visible = false;
            button.Visible = false;
            timer.Enabled = true;
            menu = false;
            cntcoins = 0;
            coinlbl.Text = "Coins: 0";
            coin.Top = -1000;
        }
    }
}
